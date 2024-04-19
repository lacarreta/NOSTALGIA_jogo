using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float Speed = 7f;
    // Start is called before the first frame update
    void Start()
    {

        float SpeedX = Random.Range(0, 2) == 0 ? -1 : 1;
        float SpeedY = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(Speed * SpeedX, Speed * SpeedY, 0f);

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