using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerJump : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Rigidbody rb;
    private float moveX;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            UnityEngine.Debug.LogError("Rigidbody is missing on the Player object. Please add a Rigidbody component.");
        }
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
        
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * 500);
        }
    }

    private void FixedUpdate()
    {
        if (rb != null)
        {
            Vector2 velocity = rb.velocity;
            velocity.x = moveX;
            rb.velocity = velocity;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        if (other.transform.CompareTag("Platform"))
        {
            if (rb.velocity.y < 0)
            {
                rb.velocity = Vector3.up * 5;
            }
   
        }
        else if (other.transform.CompareTag("Tramp"))
        {
            if (rb.velocity.y < 0)
            {
                rb.velocity = Vector3.up * 9;
            }

        }
    }
}
