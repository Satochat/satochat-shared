using Satochat.Shared.Crypto;
using Xunit;

namespace Satochat.Shared.Test.Crypto {
    public class KeyEncodingTest {
        // Generated with OpenSSL
        private const string PrivateKeyPem =
            "-----BEGIN RSA PRIVATE KEY-----\n"
            + "MIIBOwIBAAJBANTMpAVZm/r1ZSJwmI0Sk4iDCHGWSQrgQaNJhcOcKtOH9uIimSa9\n"
            + "NWgpJx1vLeTb4qXWoASBRUNItyvbpBu0LoUCAwEAAQJAE+/IPigTEQQEoaFi6XSg\n"
            + "Fd4Q4HNwDHDONXoh6h2rdX3PpCIH8PcRHqUqh5H7kuCVgy93CaziMXHEQWLHhDlo\n"
            + "UQIhAP3RIcSDaM9FeghsPoHmNrmY8cxim0ZN+Abh3WgACR/nAiEA1qExsVLRj2yj\n"
            + "ECbpfpiSdxxc+pw7OTuHfJ/BfbE6ILMCIQCjRNyw2UsZUXrPYjnPO3RmbQDVVXTG\n"
            + "g68RVkci+CrmbwIgK1SpwqH0ut704LrqYuuMjk2Em/fUoQ5aoRdjqeuQz68CIQCO\n"
            + "oDtsXlJKXmIaLud+zf5cyKPH8+HZyEebhvpBvz51Fw==\n"
            + "-----END RSA PRIVATE KEY-----\n";

        // Generated with OpenSSL
        private const string PublicKeyPem =
            "-----BEGIN PUBLIC KEY-----\n"
            + "MFwwDQYJKoZIhvcNAQEBBQADSwAwSAJBANTMpAVZm/r1ZSJwmI0Sk4iDCHGWSQrg\n"
            + "QaNJhcOcKtOH9uIimSa9NWgpJx1vLeTb4qXWoASBRUNItyvbpBu0LoUCAwEAAQ==\n"
            + "-----END PUBLIC KEY-----\n";

        private const string KeyPairPem = PrivateKeyPem + PublicKeyPem;

        [Fact]
        public void TestPrivateKey() {
            var key = SatoPrivateKey.FromPem(PrivateKeyPem);
            var pem = key.ToPem();
            Assert.Equal(PrivateKeyPem, pem);
        }

        [Fact]
        public void TestPublicKey() {
            var key = SatoPublicKey.FromPem(PublicKeyPem);
            var pem = key.ToPem();
            Assert.Equal(PublicKeyPem, pem);
        }

        [Fact]
        public void TestKeyPair() {
            var keyPair = SatoKeyPair.FromPem(KeyPairPem);
            var pem = keyPair.ToPem();
            Assert.Equal(KeyPairPem, pem);
        }
    }
}
