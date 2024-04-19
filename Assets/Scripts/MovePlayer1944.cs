using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer1944 : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float h = Input.GetAxis("Horizontal");
       float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, 0, v);
        transform.position += dir * speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, -h * 60);
        
    }
}
