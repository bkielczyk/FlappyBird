using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnTime = 3f;

    int score = -1;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        InvokeRepeating("SpawnPipe", 0.0f, spawnTime);
    }

    void SpawnPipe()
    {
        GameObject newPipe = Instantiate(pipe, new Vector2(transform.position.x, transform.position.y + Random.Range(-1.5f, 1.5f)), transform.rotation);
        score++;
        scoreText.text = score.ToString();
    }
}
