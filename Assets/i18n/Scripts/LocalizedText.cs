using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace i18n {
    public class LocalizedText : MonoBehaviour {

        public string Key;
        public string[] Params;
        private Text text;

        // Start is called before the first frame update
        void Start() {
            text = GetComponent<Text>();
            text.text = Strings.Get(Key, Params);
        }
    }
}
