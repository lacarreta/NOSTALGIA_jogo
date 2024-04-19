using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhub : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    public Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        anim.SetBool("right", (h > 0.0f));
        anim.SetBool("left", (h < 0.0f));

        float v = Input.GetAxisRaw("Vertical");
        anim.SetBool("up", (v > 0.0f));
        anim.SetBool("down", (v < 0.0f));
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        rb.velocity = dir * speed;

    }

    private void OnTriggerEnter(Collider col)
    {
        AchievItem item = col.GetComponent<AchievItem>();

        if (item != null)
        {
            AchievementsControl.instance.SetAchiement(item, true);
        }
        if (col.CompareTag("chave"))
        {
            Destroy(col.gameObject);
        }
    }
}