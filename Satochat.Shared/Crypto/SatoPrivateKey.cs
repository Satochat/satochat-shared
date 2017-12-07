using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;

namespace Satochat.Shared.Crypto {
    public class SatoPrivateKey : SatoAsymmetricKey {
        private readonly AsymmetricKeyParameter _key;

        public SatoPrivateKey(AsymmetricKeyParameter key) : base(key) {
            _key = key;
        }

        public override byte[] ToDer() {
            var info = PrivateKeyInfoFactory.CreatePrivateKeyInfo(_key);
            var der = info.GetDerEncoded();
            return der;
        }

        public static SatoPrivateKey FromPem(string input) {
            var key = Pem.Decode<AsymmetricKeyParameter>(input);
            if (key == null) {
                var key2 = Pem.Decode<AsymmetricCipherKeyPair>(input);
                if (key2 == null) {
                    return null;
                }

                key = key2.Private;
            }

            return new SatoPrivateKey(key);
        }
    }
}
