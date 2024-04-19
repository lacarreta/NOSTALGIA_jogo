using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogControl : MonoBehaviour
{
    public static DialogControl instance;
    public Image img;
    public Text dialog;
    public GameObject painel;
    public float time;

    private void Start()
    {


        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        HidePanel();
    }

    public void SetDialog(DialogItem item)
    {
        img.sprite = item.sprite;
        dialog.text = item.dialog;
        ShowPanel();
        Invoke("HidePanel", time);
    }

    void ShowPanel()
    {
        painel.SetActive(true);
    }

    void HidePanel()
    {
        painel.SetActive(false);
    }
}