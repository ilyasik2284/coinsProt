using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CoinsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] prefab = new GameObject[2];

    void Awake()
    {
        for (int i = 0; i < 50; i++)
        {
            SpawnCoins();
            SpawnCoins();
        }
    }

    void SpawnCoins()
    {
        float X = Random.Range(-5.7f, 3.2f); //������� �����
        float Y = Random.Range(-4.45f, 2.3f);
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