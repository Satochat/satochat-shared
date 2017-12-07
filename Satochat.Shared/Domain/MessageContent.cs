namespace Satochat.Shared.Domain {
    public class MessageContent {
        public string Body { get; }

        public MessageContent(string body) {
            Body = body;
        }
    }
}
