using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
   public string upAni = "";
   public string downAni = "";
   public string leftAni = "";
   public string rightAni = "";

    string nowMode = "";

    private void Start() {
        nowMode = upAni;
    }
    
    private void Update() {
        if(Input.GetKey("up")){
            nowMode = upAni;
        }
         if(Input.GetKey("down")){
            nowMode = downAni;
        }
         if(Input.GetKey("left")){
            nowMode = leftAni;
        }
         if(Input.GetKey("right")){
            nowMode = rightAni;
        }
    }

    private void FixedUpdate() {
        this.GetComponent<Animator>().Play(nowMode);
    }
}

