using System;
using System.Collections.Generic;
using System.Linq;

namespace Satochat.Shared.Util {
    public static class UrlUtil {

        public static string MakeUrl(string path, IDictionary<string, string> parameters) {
            string qs = parameters == null ? null : String.Join("&", parameters.Select(kv => String.Join("=", Uri.EscapeUriString(kv.Key), Uri.EscapeUriString(kv.Value))));
            if (!String.IsNullOrEmpty(qs)) {
                path += "?" + qs;
            }
            return path;
        }
    }
}
