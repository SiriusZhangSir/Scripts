using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTSCamera : MonoBehaviour {

	public float moveSpeed;
	public float minX;
	public float maxX;
	public float minZ;
	public float maxZ;

	void Update () {

		Vector3 dir = Vector3.zero;
		Vector3 mp = Input.mousePosition;

		if(mp.x <= 0){
			dir.x = -1;				
		}
		if(mp.x >= Screen.width){
			dir.x = 1;
		}
		if(mp.y <= 0){
			dir.z = -1;				
		}
		if(mp.y >= Screen.height){
			dir.z = 1;
		}

		dir.Normalize ();
		transform.Translate (dir * moveSpeed * Time.deltaTime, Space.World);

		Vector3 currentPosition = transform.position;

		currentPosition.x = Mathf.Clamp (currentPosition.x, minX, maxX);
		currentPosition.z = Mathf.Clamp (currentPosition.z, minZ, maxZ);

		transform.position = currentPosition;

	}
}
