using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    public string Destino;
    private GameController GameController = null;
    AudioManager audioManager;

    private void Awake()
    {
        // Verifica se o objeto com a tag "Audio" existe antes de tentar acessar o componente AudioManager
        GameObject audioObject = GameObject.FindGameObjectWithTag("Audio");
        if (audioObject != null)
        {
            audioManager = audioObject.GetComponent<AudioManager>();
        }
    }

    void Start()
    {
        // Verifica se o objeto GameController existe antes de tentar acessar o componente GameController
        GameObject gameControllerObject = GameObject.Find("GameController");
        if (gameControllerObject != null)
        {
            GameController = gameControllerObject.GetComponent<GameController>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameController != null)
            {
                if (audioManager != null)
                {
                    audioManager.PlaySFX(audioManager.porta);
                }
                GameController.LoadScene(Destino);
            }
        }
    }
}
