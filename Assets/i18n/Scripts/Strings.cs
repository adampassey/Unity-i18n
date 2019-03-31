using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace i18n {
    public static class Strings {

        private static Dictionary<string, string> strings;

        /// <summary>
        /// Load strings directly from Dictionary
        /// </summary>
        /// <param name="s">key to value dictionary</param>
        public static void LoadStrings(Dictionary<string, string> s) {
            strings = s;
        }

        /// <summary>
        /// Add a single string to the localization dictionary
        /// </summary>
        /// <param name="key">The string key</param>
        /// <param name="value">The string value</param>
        public static void AddString(string key, string value) {
            strings.Add(key, value);
        }

        /// <summary>
        /// Retrieve localized string using key, allowing formatting
        /// </summary>
        /// <param name="key">The string key</param>
        /// <param name="p">Parameters to format string with</param>
        /// <returns></returns>
        public static string Get(string key, params string[] p) {
            strings.TryGetValue(key, out string result);

            return string.Format(result, p);
        }
    }
}
