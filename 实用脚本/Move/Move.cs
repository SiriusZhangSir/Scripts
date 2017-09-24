using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float moveSpeed;
	public float rotateSpeed;

	
	void Update () {
		float vertical = Input.GetAxis ("Vertical");
		float horizontal = Input.GetAxis ("Horizontal");

		transform.Translate (transform.forward * moveSpeed * vertical * Time.deltaTime);
		transform.Rotate (transform.up * horizontal * rotateSpeed * Time.deltaTime);
	}
}
