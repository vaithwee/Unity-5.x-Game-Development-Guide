using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_3_5_3 : MonoBehaviour {

	public Texture texture;
	public GameObject obj;
	private Renderer render;

	// Use this for initialization
	void Start () {
		obj = GameObject.Find("Cube");
		render = obj.GetComponent<Renderer>();
	}

	/// <summary>
	/// OnGUI is called for rendering and handling GUI events.
	/// This function can be called multiple times per frame (one call per event).
	/// </summary>
	void OnGUI()
	{
		if (GUILayout.Button("Add Color", GUILayout.Width(100), GUILayout.Height(50)))
		{
			render.material.color = Color.red;
		}

		if (GUILayout.Button("Add Texture", GUILayout.Width(100), GUILayout.Height(50)))
		{
			render.material.mainTexture = texture;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
