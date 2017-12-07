using System.Collections.Generic;
using System.Linq;
using Satochat.Shared.Util;

namespace Satochat.Shared.Domain {
    public class Conversation {
        public class MessageDeliveryStatusChangedEventArg {
            public Message Message { get; }
            public MessageDeliveryStatus Status { get; }

            public MessageDeliveryStatusChangedEventArg(Message message, MessageDeliveryStatus status) {
                Message = message;
                Status = status;
            }
        }

        public delegate void MessageDeliveryStatusChangedHandler(object sender, MessageDeliveryStatusChangedEventArg arg);
        public event MessageDeliveryStatusChangedHandler MessageDeliveryStatusChanged;

        public class AddedEventArg {
            public Message Message { get; }

            public AddedEventArg(Message message) {
                Message = message;
            }
        }

        public delegate void MessageAddedHandler(object sender, AddedEventArg arg);
        public event MessageAddedHandler MessageAdded;

        public class UserTypingEventArg {
            public string UserUuid { get; }

            public UserTypingEventArg(string userUuid) {
                UserUuid = userUuid;
            }
        }

        public delegate void UserTypingHandler(object sender, UserTypingEventArg arg);
        public event UserTypingHandler UserTyping;

        public string Uuid { get; }
        public IEnumerable<string> Participants { get; }
        private ICollection<Message> _messages { get; } = new List<Message>();

        public Conversation(IEnumerable<string> participants) {
            Participants = new SortedSet<string>(participants);
            Uuid = ConversationUtil.GenerateUuid(Participants);
        }

        public void AddMessage(Message message) {
            lock (this) {
                _messages.Add(message);
            }

            MessageAdded?.Invoke(this, new AddedEventArg(message));
        }

        public Message GetMessage(string uuid) {
            lock (this) {
                return _messages.SingleOrDefault(m => m.Uuid == uuid);
            }
        }

        public Message GetMessageForRecipient(string recipientUuid) {
            lock (this) {
                return _messages.SingleOrDefault(m => m.RecipientUuid == recipientUuid);
            }
        }

        public IEnumerable<Message> GetMessages() {
            lock (this) {
                return _messages.OrderBy(m => m.Timestamp).ToArray();
            }
        }

        public void SetMessageDeliveryStatus(string uuid, MessageDeliveryStatus status) {
            var message = GetMessage(uuid);
            var oldStatus = message.DeliveryStatus;
            if (oldStatus != status) {
                message.DeliveryStatus = status;
                MessageDeliveryStatusChanged?.Invoke(this, new MessageDeliveryStatusChangedEventArg(message, status));
            }
        }

        public void RaiseUserTyping(string userUuid) {
            UserTyping?.Invoke(this, new UserTypingEventArg(userUuid));
        }
    }
}
