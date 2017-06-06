using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_3_7_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// OnGUI is called for rendering and handling GUI events.
	/// This function can be called multiple times per frame (one call per event).
	/// </summary>
	void OnGUI()
	{
		GUILayout.Label("当前游戏时间："+ Time.time);
		GUILayout.Label("当前游戏时间缩放：" + Time.timeScale);
		GUILayout.Label("上一帧所消耗的时间:" + Time.deltaTime);
		GUILayout.Label("固定增量时间：" + Time.fixedTime);
		GUILayout.Label("上一帧消耗的固定时间：" + Time.fixedDeltaTime);
		GUILayout.Label("真实逝去的时间：" + Time.realtimeSinceStartup);
	}
}
