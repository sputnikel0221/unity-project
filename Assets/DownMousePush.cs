using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownMousePush : MonoBehaviour
{
    public float speed;

    void OnMouseDown() {
        Debug.Log("clicked");
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var wPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var hit = Physics2D.Raycast(wPos, Vector2.zero);
            if (hit)
            {
                if (hit.collider.gameObject.name == this.name)
                {
                    Debug.Log("Plz Raycast is detected");
                    this.transform.Translate(-speed / 50, 0, 0);
                }
            }
        }
    }
}
