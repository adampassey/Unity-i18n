using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace i18n {
    public class LogStringOnLoad : MonoBehaviour {
        public string Key;

        // Start is called before the first frame update
        void Start() {
            LogTestString();
        }

        public void LogTestString() {
            Debug.Log(i18n.Strings.Get("hello", "Adam"));
        }
    }
}
