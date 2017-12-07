namespace Satochat.Shared.ViewModels {
    public static class WhoamiViewModel {
        public class ViewResult {
            public string Uuid { get; set; }

            public ViewResult(string uuid) {
                Uuid = uuid;
            }
        }
    }
}
