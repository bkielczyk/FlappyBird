using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnTime = 3f;

    void Start()
    {
        InvokeRepeating("SpawnPipe", spawnTime, spawnTime);
    }

    void SpawnPipe()
    {
        GameObject newPipe = GameObject.Instantiate(pipe, transform.position, transform.rotation);
    }
}
