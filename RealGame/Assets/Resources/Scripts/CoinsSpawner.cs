using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] prefab = new GameObject[2];
    private int LowBounder = 50;
    private int HighBounder = 70;
    // [SerializeField] private Vector3 local;


    void Awake()
    {

        for (int i = 0; i < Random.Range(15, 30); i++)
        {
            SpawnCoins();
        }


    }

    void SpawnCoins()
    {
        float X = Random.Range(-4.3f, 3.2f);
        float Y = Random.Range(-3.35f, 2.29f);
        float Z = 0;


        Vector3 local = transform.position;
        local = new Vector3(X, Y, Z);

        int index = Random.Range(0, prefab.Length);

        Instantiate(prefab[index], local, Quaternion.identity);
    }

}
