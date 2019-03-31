using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace i18n {

    public class Loader : MonoBehaviour {

        public string LangDirectory = "Lang";
        public string DefaultLang = "en-US";

        [System.Serializable]
        private class LocalizationData {
            public LocalizationItem[] strings;
        }

        [System.Serializable]
        private class LocalizationItem {
            public string key;
            public string value;
        }

        // Start is called before the first frame update
        void Start() {
            Load(DefaultLang, LangDirectory);
        }

        public void Load(string lang, string directory) {
            string path = Path.Combine(Application.streamingAssetsPath, directory, $"{lang}.json");
            if (File.Exists(path)) {
                string jsonData = File.ReadAllText(path);
                LocalizationData localizationData = JsonUtility.FromJson<LocalizationData>(jsonData);
                Parse(localizationData);
            } else {
                Debug.LogError($"Unable to load lang file at path ${path}");
            }
        }

        private void Parse(LocalizationData data) {
            Dictionary<string, string> keys = new Dictionary<string, string>();

            for (int i = 0; i < data.strings.Length; i++) {
                keys.Add(data.strings[i].key, data.strings[i].value);
            }

            Strings.LoadStrings(keys);
        }
    }
}
