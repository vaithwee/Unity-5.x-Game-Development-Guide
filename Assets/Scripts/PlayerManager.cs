using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	private Animator animator;
	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		animator = GetComponent<Animator>();
	}
	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		animator.SetFloat("Speed", h * h + v * v);
		animator.SetFloat("Direction", h, 0.25f, Time.deltaTime);

		if (Input.GetKey(KeyCode.Space))
		{
			animator.SetBool("Jump", true);
			Debug.Log("Jump");
		}
		else
		{
			animator.SetBool("Jump", false);
		}
	}
}
