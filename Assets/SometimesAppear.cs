using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SometimesAppear : MonoBehaviour
{
    public GameObject newPrefab;
    public float intervalSec = 1;
    
    //CreatePrefab이라는 함수를 반복하는 것을 예약해둠.
    void Start(){
        InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
    }

    // Update is called once per frame
    void CreatePrefab()
    {
        Vector3 newPos = this.transform.position;
        // newPos.x = -0.1f;
        // newPos.y = -3.66f;
        // newPos.z = 0;
        GameObject newGameObject = Instantiate(newPrefab) as GameObject;
        newGameObject.transform.position = newPos;
    }
}
