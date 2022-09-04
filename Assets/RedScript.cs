using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame //1프레임마다 실행 (1초에 60~80번 실행 / 천차만별)
    void Update()
    {
        // this.transform.Translate(0.1f,0,0);
    }


    public float speed = 5;
    public float angle = 5;
    
    void FixedUpdate() //1초에 정확히 50번 실행
    {
        this.transform.Translate(speed/50,0,0);
        this.transform.Rotate(0,0,angle/50);
    }
}
