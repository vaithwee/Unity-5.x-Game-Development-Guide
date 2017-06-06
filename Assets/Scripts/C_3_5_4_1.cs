using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_3_5_4_1 : MonoBehaviour {

	public GameObject receiver;
	// Use this for initialization
	void Start () {
		receiver.SendMessage("ShowNumber", 100, SendMessageOptions.DontRequireReceiver);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
