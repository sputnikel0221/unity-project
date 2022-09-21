using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionShowit : MonoBehaviour
{
    public string targetName;
    public string showName;
    GameObject showObject;

    //위치는 하고 있고, 숨겨져 있다가 나와야 하기 떄문에, hide클래스와 다르게 Start에서 안보이게 설정 필요.
    void Start() {
        showObject= GameObject.Find(showName);
        showObject.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == targetName){
            showObject.SetActive(true);
        }
    
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.name == targetName){
            showObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
