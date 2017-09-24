using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour {

	public float moveSpeed;
	public float rotateSpeed;
	
	void Update () {

		Vector3 forward = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		Vector3 forwardPoint = transform.position + forward;

		float inputMotionValue = Mathf.Max (Mathf.Abs(forward.x),Mathf.Abs(forward.z));

		if(inputMotionValue > 0){
			Quaternion lookRot = Quaternion.LookRotation (forward);
			transform.rotation = Quaternion.Slerp (transform.rotation, lookRot,rotateSpeed*inputMotionValue*Time.deltaTime);

			transform.Translate (Vector3.forward*inputMotionValue*moveSpeed*Time.deltaTime);
		}
	}
}
