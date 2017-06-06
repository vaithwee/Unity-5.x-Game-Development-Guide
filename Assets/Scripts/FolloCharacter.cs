using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolloCharacter : MonoBehaviour {

	public GameObject player;
	public Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = this.transform.position - player.transform.position  ;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// LateUpdate is called every frame, if the Behaviour is enabled.
	/// It is called after all Update functions have been called.
	/// </summary>
	void LateUpdate()
	{
		this.transform.position = player.transform.position + offset;
	}
}
