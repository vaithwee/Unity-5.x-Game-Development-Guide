using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_7_3_1 : MonoBehaviour {

	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider other)
	{
		Debug.Log(Time.time + "enter the game obj is " + other.gameObject.name);
	}

	/// <summary>
	/// OnTriggerStay is called once per frame for every Collider other
	/// that is touching the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerStay(Collider other)
	{
		Debug.Log(Time.time + "stay the game obj is " + other.gameObject.name);
	}
	/// <summary>
	/// OnTriggerExit is called when the Collider other has stopped touching the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerExit(Collider other)
	{
		Debug.Log(Time.time + "exit game obj is " + other.gameObject.name);
	}
}
