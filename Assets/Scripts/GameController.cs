using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public bool[] chave;

    //private static bool created = false;
    public static GameController instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        //if (!created)
        //{
        //    created = true;
            //Debug.Log("Awake: " + this.gameObject);
        //}
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadScene(string Nome)
    {
        SceneManager.LoadScene(Nome, LoadSceneMode.Single);
    }

    public void ColetarItem(int num)
    {
        chave[num] = true;
    }
}
