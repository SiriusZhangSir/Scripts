using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Rotate : MonoBehaviour {

	public Transform target;
	public Transform cameraChild;
	public float minDistance;
	public float maxDistance;
	public float scaleSpeed;
	public float rotateSpeed;

	private float currentScale;
	private Vector3 currentRotation;
	private Vector3 LastMousePosition;

	void Start(){
		currentScale = cameraChild.position.z;
		currentRotation = transform.eulerAngles;

		LastMousePosition = Input.mousePosition;
	}

	void Update(){
		Vector3 mouseDelta = Input.mousePosition - LastMousePosition;
		LastMousePosition = Input.mousePosition;

		if(Input.GetMouseButton(1)){
			currentRotation.x += mouseDelta.y * rotateSpeed * Time.deltaTime;
			currentRotation.y += mouseDelta.x * rotateSpeed * Time.deltaTime;
		}

		currentScale += -Input.mouseScrollDelta.y * scaleSpeed * Time.deltaTime;
		currentScale = Mathf.Clamp (currentScale, minDistance, maxDistance);

		transform.position = target.position;
		transform.eulerAngles = currentRotation;
		cameraChild.localPosition = new Vector3 (0, 0, currentScale);
	}
}
