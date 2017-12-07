using Org.BouncyCastle.Crypto;

namespace Satochat.Shared.Crypto {
    public class SatoKeyPair {
        private readonly SatoPrivateKey _privateKey;
        private readonly SatoPublicKey _publicKey;

        public SatoKeyPair(SatoPrivateKey privateKey, SatoPublicKey publicKey) {
            _privateKey = privateKey;
            _publicKey = publicKey;
        }

        public SatoPrivateKey GetPrivateKey() => _privateKey;
        public SatoPublicKey GetPublicKey() => _publicKey;

        public static SatoKeyPair FromPem(string input) {
            var keyPair = Pem.Decode<AsymmetricCipherKeyPair>(input);
            return new SatoKeyPair(new SatoPrivateKey(keyPair.Private), new SatoPublicKey(keyPair.Public));
        }

        public string ToPem() => _privateKey.ToPem() + _publicKey.ToPem();
    }
}