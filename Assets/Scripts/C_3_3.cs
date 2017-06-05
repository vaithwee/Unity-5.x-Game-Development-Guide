using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_3_3 : MonoBehaviour {

    string text = "";
    string myName = "";

    private void OnGUI()
    {
        GUILayout.Label("请输入你的名字：");
        text = GUILayout.TextField(text);
        if (GUILayout.Button("提交"))
        {
            myName = text;
        }

        if (!string.IsNullOrEmpty(myName))
        {
            GUILayout.Label("提交成功，名字：" + myName);
        }
    }
}
