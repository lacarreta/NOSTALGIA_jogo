using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievItem : MonoBehaviour
{
    public int id;
    public GameObject ativarObj;

    void Start()
    {
        if (AchievementsControl.instance.achievements[id] == true)
        {
            Destroy(gameObject);
        }
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ativarObj.SetActive(false);
            gameObject.SetActive(true);
        }
    }
}
