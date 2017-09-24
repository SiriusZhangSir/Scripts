using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
	
	void OnGUI(){
		if(GUILayout.Button("LoadScene")){
			StartCoroutine (LoadScenes());
		}
	}

	IEnumerator LoadScenes(){

		var myAssetBundle = AssetBundle.LoadFromFile (Path.Combine (Application.streamingAssetsPath, "sceneasset"));
		yield return myAssetBundle;

//		WWW www = WWW.LoadFromCacheOrDownload(Path.Combine (Application.streamingAssetsPath,"sceneasset"),0);
//		yield return www;
//		var myAssetBundle = www.assetBundle;

		SceneManager.LoadScene ("test",LoadSceneMode.Single);
	}
}

