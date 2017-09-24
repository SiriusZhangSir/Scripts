using UnityEngine;  
using System.Collections;  
  
public class ShowDebugInfo : MonoBehaviour   
{  
    void Start()  
    {  
        #if SHOW_DEBUG_MESSAGES  
        Debug.Log("Pos: " + transform.position.ToString());  
        #endif  
  
        Debug.Log("Start funciton called");  
    }  
}  

//Player Settings 	---> 	Scripting Define Symbols:	定义脚本符号
	没有在Configuration中指定脚本定义符号时 在 "#if 定义的符号名" 和"#endif" 之间的代码会被编译器忽略，而不参与编译。
    与此相反，则所有代码都会参与编译。