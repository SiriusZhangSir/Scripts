using UnityEditor;
using UnityEngine;

public class Editor : MonoBehaviour {

	[MenuItem("Editor/Build Asset Bundles")]
	static void BuildABs(){
		BuildPipeline.BuildAssetBundles (
			Application.dataPath + "/StreamingAssets",
			BuildAssetBundleOptions.None, 
			BuildTarget.StandaloneWindows);
	}
}
