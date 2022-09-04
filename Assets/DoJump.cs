using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoJump : MonoBehaviour
{
    public float speed = 3;
    public int max_count = 100;
    
    int count=0;
    
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count +=1;
        if(count>=max_count){
            if(count%2==0){
                this.transform.Translate(0,speed/50,0);
            }else{
                this.transform.Translate(0,-speed/50,0);
            }
        }
    }
}
