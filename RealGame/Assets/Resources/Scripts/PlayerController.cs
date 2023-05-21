using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private RaycastHit2D _hit;
    private Vector3 _moveSide;
    private BoxCollider2D _boxCollider2d;

    void Awake()
    {
        _boxCollider2d = GetComponent<BoxCollider2D>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal"); 
        float y = Input.GetAxisRaw("Vertical");

        _moveSide = new Vector3(x, y, 0);

        if (_moveSide.x > 0)
        {
            transform.localScale = Vector3.one;
        }
        else if (_moveSide.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);

        }


        _hit = Physics2D.BoxCast(transform.position, _boxCollider2d.size, 0, new Vector2(_moveSide.x, 0), Mathf.Abs(_moveSide.x * Time.deltaTime), LayerMask.GetMask("Player", "Walls"));
        if (_hit.collider == null)
        {
            transform.Translate(_moveSide.x * Time.deltaTime, 0, 0);
        }

        _hit = Physics2D.BoxCast(transform.position, _boxCollider2d.size, 0, new Vector2(0, _moveSide.y), Mathf.Abs(_moveSide.y * Time.deltaTime), LayerMask.GetMask("Player", "Walls"));
        if (_hit.collider == null)
        {
            transform.Translate(0, _moveSide.y * Time.deltaTime, 0);
        }



    }
}