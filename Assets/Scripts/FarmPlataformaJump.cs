using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmPlataformaJump : MonoBehaviour
{
    public GameObject platformPrefab;

    public int platformCount = 300;

    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += UnityEngine.Random.Range(.5f, 2f);
            spawnPosition.x = UnityEngine.Random.Range(-5f, 5);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
