using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform ball; // Referência para o transform da bola (arraste o GameObject da bola para este campo no Inspector)
    public float moveSpeed = 5f; // Velocidade de movimento do inimigo

    void Update()
    {
        if (ball != null)
        {
            // Calcula a direção para a bola apenas ao longo do eixo Y
            float directionY = ball.position.y - transform.position.y;

            // Move o inimigo na direção vertical da bola
            transform.Translate(Vector3.up * directionY * moveSpeed * Time.deltaTime);
        }
    }
}
