using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NewAssetBundleLoad : MonoBehaviour {

	public void OnGUI(){
		if(GUILayout.Button("sphereLoad")){
			StartCoroutine (LoadSphere());
		}
		if(GUILayout.Button("cubeLoad")){
			StartCoroutine (LoadCube());
		}

	}

	IEnumerator LoadSphere(){
		var myAssetBundle = AssetBundle.LoadFromFile (Path.Combine(Application.streamingAssetsPath,"sphereasset"));	
		yield return myAssetBundle;

		if(myAssetBundle == null){
			Debug.Log ("Failed to load AssetBundle");
		}
		var prefab = myAssetBundle.LoadAsset ("Sphere");
		yield return Instantiate (prefab);

		myAssetBundle.Unload (false);
	}

	IEnumerator LoadCube(){
		var myAssetBundle = AssetBundle.LoadFromFile (Path.Combine(Application.streamingAssetsPath,"cubeasset"));
		yield return myAssetBundle;

		if(myAssetBundle == null){
			Debug.Log ("Failed to load AssetBundle");
		}
		Object[] assets = myAssetBundle.LoadAllAssets ();

		foreach (Object obj in assets) {
			yield return Instantiate (obj);
		}

		myAssetBundle.Unload (false);
	}
}
