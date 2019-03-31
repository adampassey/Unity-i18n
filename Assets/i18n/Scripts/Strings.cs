using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace i18n {
    public static class Strings {

        private static Dictionary<string, string> strings;

        public static void LoadStrings(Dictionary<string, string> s) {
            strings = s;
        }

        public static void AddString(string key, string value) {
            strings.Add(key, value);
        }

        public static string Get(string key, params string[] p) {
            strings.TryGetValue(key, out string result);

            return string.Format(result, p);
        }
    }
}
