using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class PlayerMovement : MonoBehaviour
{
    private Vector3 moveSide;
    private BoxCollider2D boxCollider2d;

    void Awake()
    {
        boxCollider2d= GetComponent<BoxCollider2D>(); 
    }


    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveSide = new Vector3(x,y,0);

        if (moveSide.x > 0)
            transform.localScale = Vector3.one;

        else if (moveSide.x < 0) 
            transform.localScale = new Vector3(-1,1,1);

        transform.Translate(moveSide * Time.deltaTime);
    }
}
