﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public int numberOfEnemies;
    public GameObject objectToSpawn;

    private float spawnRadius = 3;
    private Vector3 spawnPosition;

	// Use this for initialization
	void Start ()
    {
        SpawnObject();
		
	}
	
	//// Update is called once per frame
	//void Update () {
		
	//}

    void SpawnObject()
    {
        for(int i =0;i<numberOfEnemies;i++)
        {
            spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;

            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}
