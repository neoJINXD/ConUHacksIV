﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy2 : MonoBehaviour
{

    public GameObject[] enemyObjects;
    int enemyCounter=0;
    int maximum = 15;
    float maxSpawnRateInSeconds = 5f;
    // Start is called before the first frame update;
    void Start()
    {
        Invoke ("spawnEnemy", maxSpawnRateInSeconds);
    }

    void spawnEnemy()
    {
        GameObject a = Instantiate(enemyObjects[UnityEngine.Random.Range(0, enemyObjects.Length - 1)]) as GameObject;
        a.transform.position = new Vector2 (Random.Range (-6.5f, 6.5f), Random.Range (-4.3f, 4.3f));
        enemyCounter++;
        scheduleNextEnemySpawn();
    }
   
   void scheduleNextEnemySpawn()
   {
       float spawnInSeconds;
       
        if(maxSpawnRateInSeconds > 1f)
            spawnInSeconds = Random.Range(1f, maxSpawnRateInSeconds);
        else
            spawnInSeconds = 1f;

        if (enemyCounter >= maximum)
            CancelInvoke("spawnEnemy");
        else
            Invoke ("spawnEnemy", spawnInSeconds);
   }
}
