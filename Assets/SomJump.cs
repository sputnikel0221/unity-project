using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomJump : MonoBehaviour
{
    public float speed = 3;
    public int max_count = 100;
    
    int count=0;
    bool flag = false;
    
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count +=1;
        if(count>=max_count){
            if(flag==true){
                this.transform.Translate(0,-speed/50,0);
            }else{
                this.transform.Translate(0,speed/50,0);
            }
            count = 0; //cout를 다시세어 1초마다 1번 움직이게
            flag = !flag;
        }
    }
}
