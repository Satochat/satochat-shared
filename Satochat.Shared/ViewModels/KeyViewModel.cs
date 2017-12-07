using System.Collections.Generic;

namespace Satochat.Shared.ViewModels {
    public static class KeyViewModel {
        public class PutPublicKey {
            public string Key { get; set; }

            public PutPublicKey() {
            }

            public PutPublicKey(string key) {
                Key = key;
            }
        }
        
        public class GetPublicKey {
            public string Uuid { get; set; }

            public GetPublicKey() {
            }

            public GetPublicKey(string uuid) {
                Uuid = uuid;
            }

            public IDictionary<string, string> ToParameters() {
                return new Dictionary<string, string> {
                    { nameof(Uuid), Uuid }
                };
            }
        }

        public class GetPublicKeyResult {
            public string Key { get; set; }

            public GetPublicKeyResult() {
            }

            public GetPublicKeyResult(string key) {
                Key = key;
            }
        }
    }
}
