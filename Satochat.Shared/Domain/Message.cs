using System;

namespace Satochat.Shared.Domain {
    public class Message {
        public string AuthorUuid { get; set; }
        public string Uuid { get; set; }
        public string RecipientUuid { get; set; }
        public MessageContent Content { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public MessageDeliveryStatus DeliveryStatus { get; set; }
    }
}
