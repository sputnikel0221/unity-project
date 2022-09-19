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


    //update에서 설정을 하고, fixedupdate에서 해당 설정대로 실행하는 원리.
    //update에서 계속 키를 입력받았는지 if문을 돌리면서 대기를 하며, 해당 과정을 수행 
    void Update()
    {
        //why do this
        

        if(Input.GetKey("right")){
            vx = speed;
            leftflag = false;
        }
         if(Input.GetKey("left")){
            vx = -speed;
            leftflag = true;
        }
         if(Input.GetKey("up")){
            vy = speed*3;
        }
        // if(Input.GetKey("down")){
        //     vy = -speed;
        // }
    }
    

    void FixedUpdate() {
        this.transform.Translate(vx/50,vy/50,0);
        this.GetComponent<SpriteRenderer>().flipX = leftflag;
        vx = 0;
        vy = 0;
    }
}
