using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinsDetector : MonoBehaviour
{
    public float radius = 0.5f;
    private GameObject result;

    
    void Start()
    {
       
       
        result = GameObject.FindGameObjectWithTag("DisSpawn");
        if (result == null)
        {
            Debug.Log("ok");
        }
        else
        {
          //  Destroy(gameObject);
        }
    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
      
    }

}
