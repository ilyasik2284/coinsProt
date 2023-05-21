using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CoinsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] prefab = new GameObject[2];
    private int i = 0;
    void Start()
    {
        while (i < 30)
        {
            i++;
            SpawnCoins();
           
        }
    }

    void SpawnCoins()
    {
        float X = Random.Range(-6f, 3.2f); //границы карты
        float Y = Random.Range(-4.5f, 2.3f);
        float Z = 0;

        Vector3 local = transform.position;
        local = new Vector3(X, Y, Z);
        int index = Random.Range(0, prefab.Length);

        Collider2D[] colliders = Physics2D.OverlapCircleAll(local, 0.5f);
        if (colliders.Length == 0)
        {
            Instantiate(prefab[index], local, Quaternion.identity);
        }

    }
}