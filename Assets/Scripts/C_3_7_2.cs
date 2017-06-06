using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_3_7_2 : MonoBehaviour {

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
		if (GUILayout.Button("Create Random Number"))
		{
			int i = Random.Range(0, 10);
			Debug.Log("Random number between 0 and 10 is " + i);
			float f = Random.Range(0f, 10f);
			Debug.Log("Random number between 0f and 10f is " + f);
		}
	}
}
