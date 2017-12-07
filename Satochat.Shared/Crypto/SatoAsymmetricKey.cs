using Org.BouncyCastle.Crypto;
using Satochat.Shared.Codec;
using System;
using System.Security.Cryptography;

namespace Satochat.Shared.Crypto {
    public abstract class SatoAsymmetricKey {
        private readonly AsymmetricKeyParameter _key;

        protected SatoAsymmetricKey(AsymmetricKeyParameter key) {
            _key = key;
        }

        public abstract byte[] ToDer();

        public string GetFingerprint() {
            var der = ToDer();
            var sha = SHA256.Create();
            var digest = sha.ComputeHash(der, 0, der.Length);
            var fingerprint = Hex.Encode(digest);
            return fingerprint;
        }

        public string ToBase64() {
            var der = ToDer();
            var base64 = Convert.ToBase64String(der);
            return base64;
        }

        public string ToPem() => Pem.Encode(_key);

        public AsymmetricKeyParameter GetKey() => _key;
    }
}
