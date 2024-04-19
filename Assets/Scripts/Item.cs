using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int num;
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
        {
            if (GameController.instance.chave[num] == true)
            {
                 Destroy(gameObject);
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            GameController.instance.chave[num] = true;
            Destroy(gameObject);

            if (audioManager != null)
            {
                audioManager.PlaySFX(audioManager.item);
                // Adicione aqui qualquer outra lógica relacionada ao AudioManager, se necessário.
            }
        }

    }
}
