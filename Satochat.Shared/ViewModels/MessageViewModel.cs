using System.Collections.Generic;
using System.Linq;

namespace Satochat.Shared.ViewModels {
    public static class MessageViewModel {
        public class SendMessage {
            //public string Conversation { get; set; }
            public ICollection<OutgoingEncodedMessage> Variants { get; set; } = new List<OutgoingEncodedMessage>();
        }

        public class OutgoingEncodedMessage {
            public string Recipient { get; set; }
            public string Digest { get; set; }
            public string Payload { get; set; }
            public string Iv { get; set; }
            public string Key { get; set; }

            public OutgoingEncodedMessage() { }

            public OutgoingEncodedMessage(string recipient, string digest, string payload, string iv, string key) {
                Recipient = recipient;
                Digest = digest;
                Payload = payload;
                Iv = iv;
                Key = key;
            }
        }

        public class SendMessageResult {
            public string Conversation { get; set; }
            public IEnumerable<SendMessageResultItem> Items { get; set; }

            public SendMessageResult(string conversation, IEnumerable<SendMessageResultItem> items) {
                Conversation = conversation;
                Items = items;
            }
        }

        public class SendMessageResultItem {
            public string Recipient { get; set; }
            public string Message { get; set; }

            public SendMessageResultItem(string recipient, string message) {
                Recipient = recipient;
                Message = message;
            }
        }

        public class GetMessage {
            public string Uuid { get; set; }
        }

        public class GetMessageResult {
            public string Conversation { get; set; }
            public IncomingEncodedMessage Message { get; set; }

            public GetMessageResult(string conversation, IncomingEncodedMessage message) {
                Conversation = conversation;
                Message = message;
            }
        }

        public class IncomingEncodedMessage {
            public string Uuid { get; set; }
            public string Author { get; set; }
            public string Digest { get; set; }
            public string Payload { get; set; }
            public string Iv { get; set; }
            public string Key { get; set; }
            public long Timestamp { get; set; }

            public IncomingEncodedMessage(string uuid, string author, string digest, string payload, string iv, string key, long timestamp) {
                Uuid = uuid;
                Author = author;
                Digest = digest;
                Payload = payload;
                Iv = iv;
                Key = key;
                Timestamp = timestamp;
            }
        }

        public class GetMessages {
            public string Conversation { get; set; }
        }

        public class GetMessagesResult {
            public ICollection<IncomingEncodedMessage> Messages { get; set; } = new List<IncomingEncodedMessage>();
        }
    }
}
