using Satochat.Shared.Util;
using Xunit;

namespace Satochat.Shared.Test.Util {
    public class StringUtilTest {
        [Fact]
        public void TestConvertLineEndings() {
            string withCrlf = StringUtil.ConvertLineEndings("a\nb\nc\n\n", "\r\n");
            Assert.Equal("a\r\nb\r\nc\r\n\r\n", withCrlf);
            string withNl = StringUtil.ConvertLineEndings(withCrlf, "\n");
            Assert.Equal("a\nb\nc\n\n", withNl);
            string withCr = StringUtil.ConvertLineEndings(withNl, "\r");
            Assert.Equal("a\rb\rc\r\r", withCr);
        }
    }
}
