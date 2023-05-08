using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private RaycastHit2D hit;
    private Vector3 moveSide;
    private BoxCollider2D boxCollider2d;

    void Awake()
    {
        boxCollider2d = GetComponent<BoxCollider2D>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveSide = new Vector3(x, y, 0);

        if (moveSide.x > 0)
        {
            transform.localScale = Vector3.one;
        }
        else if (moveSide.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);

        }
           


        hit = Physics2D.BoxCast(transform.position, boxCollider2d.size, 0, new Vector2(moveSide.x, 0), Mathf.Abs(moveSide.x * Time.deltaTime), LayerMask.GetMask("Player", "Walls"));
        if (hit.collider == null)
        {
            transform.Translate(moveSide.x * Time.deltaTime, 0, 0);
        }


        hit = Physics2D.BoxCast(transform.position, boxCollider2d.size, 0, new Vector2(0, moveSide.y), Mathf.Abs(moveSide.y * Time.deltaTime), LayerMask.GetMask("Player", "Walls"));
        if (hit.collider == null)
        {
            transform.Translate(0, moveSide.y * Time.deltaTime, 0);
        }
    }
}