using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb2D;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = new Vector2(0.0f, 5.0f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
