using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class spawner : MonoBehaviour
{
    public GameObject balloonsPrefab;
    public float secondsBetweenSpawn = 1;
    float nextSpawnTime;
    Vector2 screenHalfSizeWorldUnits;

    // Start is called before the first frame update
    void Start()
    {
        screenHalfSizeWorldUnits = new Vector2(Camera.main.aspect * Camera.main.orthographicSize , -Camera.main.orthographicSize);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + secondsBetweenSpawn;
            Vector2 spawnPosition = new Vector2(Random.Range(-screenHalfSizeWorldUnits.y, screenHalfSizeWorldUnits.y*2), -screenHalfSizeWorldUnits.x);
            Instantiate(balloonsPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
