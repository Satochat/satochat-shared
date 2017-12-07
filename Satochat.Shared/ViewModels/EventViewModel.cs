namespace Satochat.Shared.ViewModels {
    public static class EventViewModel {
        public class PushEvent {
            public string Uuid { get; set; }
            public string Name { get; set; }
            public string Data { get; set; }

            public PushEvent() {
            }

            public PushEvent(string uuid, string name, string data) {
                Uuid = uuid;
                Name = name;
                Data = data;
            }
        }
    }
}
