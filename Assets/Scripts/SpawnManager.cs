using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemiesToSpawn;


    public Transform[] spawnPositions;


    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2f, 1.5f);
    }

    void Update()
    {
        if(enemiesToSpawn == 0)
        {
            CancelInvoke();
        }
    }

    void SpawnEnemy()
    {

       for (int i = 0; i <spawnPositions.Length; i++)
       {
        Instantiate(enemyPrefab, spawnPositions[i].position, spawnPositions[i].rotation);
       }

       enemiesToSpawn--;
    }

}
