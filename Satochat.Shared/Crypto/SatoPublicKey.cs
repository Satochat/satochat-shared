using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;

namespace Satochat.Shared.Crypto {
    public class SatoPublicKey : SatoAsymmetricKey {
        private readonly AsymmetricKeyParameter _key;

        public SatoPublicKey(AsymmetricKeyParameter key) : base(key) {
            _key = key;
        }

        public override byte[] ToDer() {
            var info = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(_key);
            var der = info.GetDerEncoded();
            return der;
        }

        public static SatoPublicKey FromPem(string input) {
            var key = Pem.Decode<AsymmetricKeyParameter>(input);
            if (key == null) {
                var key2 = Pem.Decode<AsymmetricCipherKeyPair>(input);
                if (key2 == null) {
                    return null;
                }

                key = key2.Public;
            }

            return new SatoPublicKey(key);
        }
    }
}
