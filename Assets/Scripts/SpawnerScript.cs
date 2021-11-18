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
        GameObject newPipe = Instantiate(pipe, new Vector2(transform.position.x, transform.position.y + Random.Range(-1.5f, 1.5f)), transform.rotation);
    }
}
