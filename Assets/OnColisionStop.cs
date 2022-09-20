using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColisionStop : MonoBehaviour
{

    public string targetObjectName;
    void Start()
    {
        //시간을 움직인다. 게임에서 continue를 위한 장치, 지금은 필요 없음
        Time.timeScale = 1;
    }

    void OnCollisionEnter2D(Collision2D collision) {
        //충돌한 것의 오브젝트 이름이 대상이라면 시간을 멈춘다..
        if(collision.gameObject.name == targetObjectName){
            Time.timeScale = 0;
        }
    }
}
