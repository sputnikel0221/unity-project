using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class OnCollisonHideit : MonoBehaviour
{
    public string targetObjectName;
    public string hideObjectName;

    //해당 스크립트를 적용한 객체에 충돌한 것이 target이라면, hide객체를 숨긴다.
    void OnCollisionEnter2D(Collision2D collison) {
        if(collison.gameObject.name == targetObjectName){
            GameObject.Find(hideObjectName).SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.name == targetObjectName){
            GameObject.Find(hideObjectName).SetActive(false);
        }
    }
}
