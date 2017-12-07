using Newtonsoft.Json;

namespace Satochat.Shared.Event {
    public static class MessageEvent {
        public class UserReceivedMessage : BaseEvent<UserReceivedMessage> {
            public const string Name = "user-received-message";

            public string User { get; set; }
            public string Conversation { get; set; }
            public string Message { get; set; }

            public UserReceivedMessage(string userUuid, string conversationUuid, string messageUuid) : base(Name) {
                User = userUuid;
                Conversation = conversationUuid;
                Message = messageUuid;
            }

            protected override UserReceivedMessage GetEvent() {
                return this;
            }
        }

        public class ConversationCreated : BaseEvent<ConversationCreated> {
            public const string Name = "conversation-created";

            public string Conversation { get; set; }

            public ConversationCreated(string conversationUuid) : base(Name) {
                Conversation = conversationUuid;
            }

            protected override ConversationCreated GetEvent() {
                return this;
            }
        }

        public class NewMessageAvailable : BaseEvent<NewMessageAvailable> {
            public const string Name = "new-message-available";
            
            //public string Recipient { get; set; }
            public string Message { get; set; }

            public NewMessageAvailable(/*string recipientUuid,*/ string messageUuid) : base(Name) {
                //Recipient = recipientUuid;
                Message = messageUuid;
            }

            protected override NewMessageAvailable GetEvent() {
                return this;
            }
        }

        public class UserTypingInConversation : BaseEvent<UserTypingInConversation> {
            public const string Name = "user-typing";

            public string User { get; set; }
            public string Conversation { get; set; }

            public UserTypingInConversation(string userUuid, string conversationUuid) : base(Name) {
                User = userUuid;
                Conversation = conversationUuid;
            }

            protected override UserTypingInConversation GetEvent() {
                return this;
            }
        }
    }
}
