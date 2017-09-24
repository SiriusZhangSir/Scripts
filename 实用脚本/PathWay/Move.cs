using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	private int wayPointIndex;
	private Transform target;

	public float moveSpeed;

	void Start(){

		target = WayPoints.point [0];
	}

	void Update(){

		Vector3 dist = target.position - transform.position;

		transform.Translate (dist.normalized * moveSpeed *Time.deltaTime, Space.World);

		if(Vector3.Distance(transform.position,target.position)<0.4f){
			GetNextPoint ();
		}

	}

	void GetNextPoint(){
		if(wayPointIndex>=WayPoints.point.Length-1){
			EndPath ();
		}

		wayPointIndex++;
		target = WayPoints.point[wayPointIndex];
	}

	void EndPath(){
		Destroy (gameObject);
	}

}
