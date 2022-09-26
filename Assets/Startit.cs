using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//해당 라이브러리가 존재해야 신 전환 가능
using UnityEngine.SceneManagement;

public class Startit : MonoBehaviour
{
    public string sceneName;

//Scene 매니져에 해당 Scene 이름이 존재해야 작동가능
    void OnMouseDown(){
        SceneManager.LoadScene(sceneName);
        
    }
}
