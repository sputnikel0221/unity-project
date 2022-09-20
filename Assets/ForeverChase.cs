using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeverChase : MonoBehaviour
{
    //public으로 지정하여, 무엇을 따라갈지 인스펙터에서 설정
    public string targetObjectName;
    public float speed = 1;
    
    GameObject targetObject;
    Rigidbody2D rbody;

    void Start()
    {
        targetObject = GameObject.Find(targetObjectName);
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()
    {
        //타겟-자신의 위치를 벡터화
        Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;

        float vx = dir.x * speed;
        float vy = dir.y * speed;

        rbody.velocity = new Vector2(vx,vy);

        //(vx < 0)이 참이면 true가 되고, flipX되므로 반전을 하게 됨. 
        //캐릭터 이미지가 기본으로 오른쪽을 보므로 왼쪽을 보게 됨 .
        this.GetComponent<SpriteRenderer>().flipX = (vx < 0);

    }
}
