using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera1944 : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
