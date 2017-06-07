using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCam : MonoBehaviour {

	public Transform follow;
	public float distanceAway;
	public float distanceUp;
	public float smooth;
	private Vector3 targetPosition;

	/// <summary>
	/// LateUpdate is called every frame, if the Behaviour is enabled.
	/// It is called after all Update functions have been called.
	/// </summary>
	void LateUpdate()
	{
		targetPosition = follow.position + Vector3.up * distanceUp - follow.forward * distanceAway;
		transform.position = Vector3.Lerp(transform.position, targetPosition, smooth * Time.deltaTime);
		transform.LookAt(follow);
	}
}
