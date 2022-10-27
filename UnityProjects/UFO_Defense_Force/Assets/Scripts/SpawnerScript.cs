using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject spawner;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    // Use this for initialization
    void Start () 

    {
        InvokeReapeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()

    {
        Instantiate(spawner, transform.position, transfrom.rotation);
        if(stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
