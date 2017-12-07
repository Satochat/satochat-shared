using System;
using System.Text.RegularExpressions;

namespace Satochat.Shared.Util {
    public static class StringUtil {
        public static string ConvertLineEndings(string input, string lineEnding) {
            return Regex.Replace(input, "\r\n|[\r\n]", lineEnding);
        }

        public static string ConvertLineEndingsToSystem(string input) {
            return ConvertLineEndings(input, Environment.NewLine);
        }
    }
}
