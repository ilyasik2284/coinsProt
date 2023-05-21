using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    [SerializeField] private float _bounderX = 0.15f;
    [SerializeField] private float bounderY = 0.05f;


    void LateUpdate()
    {
        Vector3 delta = Vector3.zero;
        float deltaX = target.position.x - transform.position.x;

        if (deltaX > _bounderX || deltaX < -_bounderX)
        {
            if (transform.position.x < target.position.x)
            {
                delta.x = deltaX - _bounderX;
            }
            else
            {
                delta.x = deltaX + _bounderX;
            }
        }

        float deltaY = target.position.y - transform.position.y;

        if (deltaY > bounderY || deltaY < -bounderY)
        {
            if (transform.position.y < target.position.y)
            {
                delta.y = deltaY - bounderY;
            }
            else
            {
                delta.y = deltaY + bounderY;
            }
        }
        transform.position += new Vector3(delta.x, delta.y, 0);
    }

}
