﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_3_7_4 : MonoBehaviour {

	float rotationSpeed = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.rotation = Quaternion.Euler(0, this.rotationSpeed * Time.deltaTime, 0);
	}
}
