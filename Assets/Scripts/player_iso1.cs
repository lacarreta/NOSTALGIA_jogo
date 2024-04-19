using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_iso1 : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    public Transform model;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        rb.velocity = dir * speed;
        model.LookAt(dir);

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