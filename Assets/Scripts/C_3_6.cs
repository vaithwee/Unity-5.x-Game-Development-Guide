using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_3_6 : MonoBehaviour {

	public GameObject cube;
	public GameObject cyliner;
	// Use this for initialization
	void Start () {
		
	}

	/// <summary>
	/// OnGUI is called for rendering and handling GUI events.
	/// This function can be called multiple times per frame (one call per event).
	/// </summary>
	void OnGUI()
	{
		if (GUILayout.Button("move to left"))
		{
			cube.transform.position += new Vector3(-0.5f, 0, 0);
		}
		if (GUILayout.Button("move to right"))
		{
			cube.transform.position += new Vector3(0.5f, 0, 0);
		}

		if (GUILayout.Button("scale small"))
		{
			cube.transform.localScale *= 0.8f;
		}

		if (GUILayout.Button("scale to bigger"))
		{
			cube.transform.localScale *= 1.2f;
		}

		if (GUILayout.Button("roration"))
		{
			cube.transform.Rotate(new Vector3(5f, 5f, 5f));
		}

		if (GUILayout.Button("rotation around cylinber"))
		{
			cube.transform.RotateAround(cyliner.transform.position, Vector3.up, 10f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
