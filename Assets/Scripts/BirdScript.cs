using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
