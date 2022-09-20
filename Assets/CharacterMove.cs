using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{

//초기값

//private화시켜 쉽게 수정
public float speed = 2;

float vx=0;
float vy=0;
bool leftflag = false;
Rigidbody2D rbody;

    void Start() {
        //이 스크립트가 적용된 객체에서 Component를 가져오는데, <Rigidbody2D>라는 component를 가져와라 그리고 rbody에 저장한다.
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        //다른 rigidbody 설정도 수동 설정이 가능하다.
        rbody.sleepMode = RigidbodySleepMode2D.StartAwake;
        rbody.interpolation = RigidbodyInterpolation2D.None;
    }


    // update에서 설정을 하고, fixedupdate에서 해당 설정대로 실행하는 원리.
    // update에서 계속 키를 입력받았는지 if문을 돌리면서 대기를 하며, 해당 과정을 수행 
    void Update()
    {
        if(Input.GetKey("right")){
            vx = speed;
            leftflag = false;
        }
         if(Input.GetKey("left")){
            vx = -speed;
            leftflag = true;
        }
         if(Input.GetKey("up")){
            vy = speed;
        }
        if(Input.GetKey("down")){
            vy = -speed;
        }
    }
    

    void FixedUpdate() {
        rbody.velocity = new Vector2(vx, vy);
        this.GetComponent<SpriteRenderer>().flipX = leftflag;
        vx = 0;
        vy = 0;
    }
}
