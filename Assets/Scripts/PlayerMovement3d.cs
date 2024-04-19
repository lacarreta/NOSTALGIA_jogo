using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3d : MonoBehaviour
{
    public float speed = 5f; // Velocidade de movimento do jogador

    void Update()
    {
        // Obtém as entradas do teclado
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Calcula a direção do movimento
        Vector3 movement = new Vector3(h, 0, v) * speed * Time.deltaTime;

        // Move o jogador na direção calculada
        transform.Translate(movement);

    
    }
}
