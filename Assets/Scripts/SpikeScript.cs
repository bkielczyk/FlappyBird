using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(-Vector3.right * 3f * Time.deltaTime);
        if (transform.position.x <= -36)
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
