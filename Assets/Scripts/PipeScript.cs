using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{

    void Update()
    {
        transform.Translate(-Vector3.right * 3f * Time.deltaTime);
    }
}
