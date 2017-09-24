using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commander : MonoBehaviour {

	public RectTransform selectionRect;

	bool isSelecting = false;
	Vector3 selectionStartPosition;

	void Update(){
		selectionRect.gameObject.gameObject.SetActive (isSelecting);

		if(Input.GetMouseButtonDown(0)){
			isSelecting = true;
			selectionStartPosition = Input.mousePosition;
			selectionRect.position = selectionStartPosition;
		}

		if(isSelecting){
			Vector3 dist = Input.mousePosition - selectionStartPosition;
			selectionRect.sizeDelta = new Vector2 (Mathf.Abs (dist.x), Mathf.Abs (dist.y));
			selectionRect.localScale = new Vector3 (dist.x < 0 ? -1f : 1f, dist.y < 0 ? -1f : 1f, 1f);
		}

		if(Input.GetMouseButtonUp(0)){
			isSelecting = false;
		}
	}
}
