using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneName; // Nome da cena de destino
    public float transitionTime = 3f; // Tempo de transição em segundos

    void Start()
    {
        // Inicia a contagem regressiva para a transição
        Invoke("LoadNextScene", transitionTime);
    }

    void LoadNextScene()
    {
        // Carrega a cena de destino após o tempo especificado
        SceneManager.LoadScene(sceneName);
    }

    public void OnClickNextScene()
    {
        CancelInvoke("LoadNextScene");
        LoadNextScene();
    }
}
