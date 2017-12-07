using System;

namespace Satochat.Shared.ViewModels {
    public static class AccessTokenViewModel {
        public class GetToken {
            public string Username { get; set; }
            public string Password { get; set; }

            public GetToken(string username, string password) {
                Username = username;
                Password = password;
            }
        }

        public class GetTokenResult {
            public string Token { get; set; }
            public DateTimeOffset Expiry { get; set; }

            public GetTokenResult(string token, DateTimeOffset expiry) {
                Token = token;
                Expiry = expiry;
            }
        }
    }
}
