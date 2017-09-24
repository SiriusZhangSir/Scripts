using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MyEditorWindow : EditorWindow {

	[MenuItem("Window/Editor")]

	static void AddWindow(){
		Rect wr = new Rect (0,0,500,500);
		MyEditorWindow window = (MyEditorWindow)EditorWindow.GetWindowWithRect(typeof(MyEditorWindow),wr,true,"window name");
		window.Show ();
	}

}
