using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportamento : MonoBehaviour
{

    public bool tipo;
    public int num;

    private GameController GameController = null;

    void Start()
    {

        if (GameObject.Find("GameController"))
        {
            GameController = GameObject.Find("GameController").GetComponent<GameController>();
        }

        if (tipo == true)
            if (GameController.chave[num] == true)
            {
                transform.gameObject.SetActive(true);
            }
            else
            {
                transform.gameObject.SetActive(false);
            }
        else
        {
            if (GameController.chave[num] == true)
            {
                transform.gameObject.SetActive(false);
            }
            else
            {
                transform.gameObject.SetActive(true);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
