using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    private bool isGrounded;

    private Rigidbody rb;
    private float moveDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimento horizontal
        moveDirection = Input.GetAxis("Horizontal");
        rb.velocity = new UnityEngine.Vector3(moveDirection * moveSpeed, rb.velocity.y);

        // Verificar se o jogador está no chão
        isGrounded = IsGrounded();

        // Pular ao pressionar a tecla para cima e estiver no chão
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        // Adicione uma força vertical para simular o pulo
        rb.AddForce(UnityEngine.Vector3.up * jumpForce, ForceMode.Impulse);
    }

    // Função para verificar se o jogador está no chão
    private bool IsGrounded()
    {
        RaycastHit hit;
        float raycastDistance = 0.2f; // Ajuste conforme necessário

        return Physics.Raycast(transform.position, UnityEngine.Vector3.down, out hit, raycastDistance);
    }
}
