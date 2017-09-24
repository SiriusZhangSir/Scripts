using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadSceneAssets : MonoBehaviour {

	void OnGUI(){
		if(GUILayout.Button("LoadScene")){
			StartCoroutine (LoadScene());
		}
	}

	IEnumerator LoadScene(){
		var myAssetBUndles = AssetBundle.LoadFromFile (Path.Combine(Application.streamingAssetsPath,"sceneasset"));
		yield return myAssetBUndles;

		

		myAssetBUndles.Unload (false);

	}
}
