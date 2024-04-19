using UnityEngine;

public class PlayerPong : MonoBehaviour
{
    public float velocidade = 5.0f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
        float movimentoVertical = Input.GetAxis("Vertical");
        rb.velocity = Vector3.up * movimentoVertical * velocidade; //velocidadeMovimento;
    }
}
