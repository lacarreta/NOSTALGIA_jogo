using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlatform: MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
