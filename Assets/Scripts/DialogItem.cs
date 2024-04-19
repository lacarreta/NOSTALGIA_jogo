using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogItem : MonoBehaviour
{
    public Sprite sprite;
    public string dialog;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            DialogControl.instance.SetDialog(this);
        }
    }
}