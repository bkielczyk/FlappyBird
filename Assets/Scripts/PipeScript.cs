using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    private void Start()
    {
        Invoke("DestroyPipe", 10.0f);
    }

    void Update()
    {
        transform.Translate(-Vector3.right * 3f * Time.deltaTime);
    }

    void DestroyPipe()
    {
        Destroy(gameObject);
    }
}
