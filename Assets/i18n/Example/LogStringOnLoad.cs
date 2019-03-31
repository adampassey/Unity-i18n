using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogStringOnLoad : MonoBehaviour
{
    public string Key;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("LogTestString", 1f);
    }

    public void LogTestString() {
        Debug.Log(i18n.Strings.Get("hello", "Adam"));
    }
}
