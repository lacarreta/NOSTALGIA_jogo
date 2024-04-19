using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercrossing : MonoBehaviour
{
    public float speed = 6.0f;

    private Rigidbody rb; // Adicionado o Rigidbody

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Inicializa o Rigidbody
        if (rb == null)
        {
            UnityEngine.Debug.LogError("Rigidbody is missing on the Player object. Please add a Rigidbody component.");
        }
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = 0.9f;
        Vector3 dir = new Vector3(x, 0, y) * Time.deltaTime * speed;
        transform.Translate(dir);

        if (Input.GetKeyDown(KeyCode.UpArrow) && rb != null) // Verifica se o rb não é nulo
        {
            rb.AddForce(Vector3.up * 500);
        }
    }
}
