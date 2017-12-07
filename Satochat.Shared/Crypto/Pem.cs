using System;
using Org.BouncyCastle.OpenSsl;
using System.IO;

namespace Satochat.Shared.Crypto {
    public static class Pem {
        public static string Encode<T>(T input) {
            using (var sw = new StringWriter()) {
                var pw = new PemWriter(sw);
                pw.WriteObject(input);
                pw.Writer.Flush();
                var str = sw.ToString();

                if (Environment.NewLine != "\n") {
                    str = str.Replace(Environment.NewLine, "\n");
                }

                return str;
            }
        }

        public static T Decode<T>(string input) where T : class {
            using (var sr = new StringReader(input)) {
                var pr = new PemReader(sr);
                return pr.ReadObject() as T;
            }
        }
    }
}
