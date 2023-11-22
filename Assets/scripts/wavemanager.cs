using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wavemanager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject[] spawnpoints;
    float nextSpawn = 0f;
    float spawnRate = 1f;
    int rnd;


    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            System.Random rndom = new System.Random();
            rnd = rndom.Next(0, 7);
            GameObject enemyobj = Instantiate(enemy, spawnpoints[rnd].transform);
            spawnRate -= 0.005f;
        }
        spawnRate = Mathf.Clamp(spawnRate, 0.075f, 1f);
    }
}
