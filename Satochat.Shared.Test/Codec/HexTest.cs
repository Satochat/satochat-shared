using System;
using Satochat.Shared.Codec;
using Xunit;

namespace Satochat.Shared.Test.Codec {
    public class HexTest {
        [Fact]
        public void TestEncode() {
            string encoded = Hex.Encode(new byte[] { 0, 1, 2, 3, 4 });
            Assert.Equal("0001020304", encoded);
        }

        [Fact]
        public void TestDecode() {
            Assert.Throws<NotImplementedException>(() => Hex.Decode(""));
        }
    }
}
