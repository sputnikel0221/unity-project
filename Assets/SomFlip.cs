using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomFlip : MonoBehaviour
{

    public int max = 50;

    int count = 0;
    bool flip = false;
    // Start is called before the first frame update
    void Start()
    {
        count = 0; //왜 굳이 또 리셋?
    }

    // Update is called once per frame
    void FixedUpdate() //이 안의 내용은, 50번 동안 반복하는데, 1초동안 진행된다. 
    {
        //count가 50이라는 것은 현실 1초를 의미
        count +=1;
        //1초가 지나면 180으로 rotate한다.
        if(count>=max){
            this.transform.Rotate(0,0,180);
            count = 0;
            flip = !flip;
            this.GetComponent<SpriteRenderer>().flipY = flip;
        }
    }
}
