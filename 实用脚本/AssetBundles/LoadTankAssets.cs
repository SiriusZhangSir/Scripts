using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadTankAssets : MonoBehaviour {

	public void OnGUI(){
		if(GUILayout.Button("Tank")){
			StartCoroutine (Tank());
		}
	}

	IEnumerator Tank(){
		var myAssetBundle = AssetBundle.LoadFromFile (Path.Combine(Application.streamingAssetsPath,"tankassets"));
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
