using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;

namespace Satochat.Shared.Crypto {
    public class SatoKeygen {
        private const int KeyPairSize = 2048; // TODO: 4096

        public static SatoKeyPair NewKeyPair() {
            var gen = new RsaKeyPairGenerator();
            gen.Init(new KeyGenerationParameters(new SecureRandom(), KeyPairSize));
            var bcKeyPair = gen.GenerateKeyPair();
            var keyPair = new SatoKeyPair(new SatoPrivateKey(bcKeyPair.Private), new SatoPublicKey(bcKeyPair.Public));
            return keyPair;
        }
    }
}
