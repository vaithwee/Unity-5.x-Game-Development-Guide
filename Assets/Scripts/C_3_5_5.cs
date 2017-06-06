using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_3_5_5 : MonoBehaviour {

	public GameObject prefabs;
	// Use this for initialization
	void Start () {
		GameObject obj = Instantiate(prefabs) as GameObject;
		obj.transform.position = new Vector3(0, 5, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
