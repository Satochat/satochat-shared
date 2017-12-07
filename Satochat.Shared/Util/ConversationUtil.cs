using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Satochat.Shared.Codec;

namespace Satochat.Shared.Util
{
    public static class ConversationUtil {
        public static string GenerateUuid(IEnumerable<string> participants) {
            var sortedParticipants = new SortedSet<string>(participants);
            var concatenated = Encoding.ASCII.GetBytes(String.Join(",", sortedParticipants));
            var sha = SHA256.Create();
            var digest = sha.ComputeHash(concatenated, 0, concatenated.Length);
            var digestHex = Hex.Encode(digest);
            return digestHex;
        }
    }
}
