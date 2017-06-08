using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_7_6 : MonoBehaviour {

	private Vector3 direction = new Vector3(1, 0, 0);
	private float distance = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += direction * Time.deltaTime;
		Ray ray = new Ray(transform.position, direction);
		RaycastHit info;
		if (Physics.Raycast(ray,out info, distance))
		{
			Debug.Log("前方有障碍" + info.collider.name);
		}

		Debug.DrawLine(ray.origin, ray.origin + direction * distance);
	}
}
