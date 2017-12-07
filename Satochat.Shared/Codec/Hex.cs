using System;
using System.Text;

namespace Satochat.Shared.Codec {
    public static class Hex {
        public static string Encode(byte[] input) {
            var sb = new StringBuilder();
            foreach (var b in input) {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

        public static byte[] Decode(string input) {
            throw new NotImplementedException("Not yet implemented");
        }
    }
}
