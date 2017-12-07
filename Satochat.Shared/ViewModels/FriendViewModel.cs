namespace Satochat.Shared.ViewModels {
    public static class FriendViewModel {
        public class ViewResult {
            public string Uuid { get; set; }
            public bool AllowCommunication { get; set; }

            public ViewResult(string uuid, bool allowCommunication) {
                Uuid = uuid;
                AllowCommunication = allowCommunication;
            }
        }
    }
}
