using UnityEngine;

public class SFXPorta : MonoBehaviour
{
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (audioManager != null)
            {
                audioManager.PlaySFX(audioManager.porta);
                // Adicione aqui qualquer outra lógica relacionada ao AudioManager, se necessário.
            }
        }
    }
}
