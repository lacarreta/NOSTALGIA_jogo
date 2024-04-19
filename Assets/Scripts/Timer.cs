using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;

            // Verifica se o tempo restante é menor ou igual a 10 segundos
            if (remainingTime <= 10)
            {
                timerText.color = Color.red;
            }
        }
        else if (remainingTime <= 0)
        {
            remainingTime = 0;

            timerText.color = Color.red;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
