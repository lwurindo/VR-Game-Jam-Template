using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    private bool isPaused = true;

    private void Start()
    {
        Time.timeScale = 0; // Inicialmente, pausa a cena definindo o tempo como zero.
    }

    private void Update()
    {
        if (Input.GetButtonDown("YourButtonName")) // Substitua "YourButtonName" pelo nome do botão (por exemplo, "A").
        {
            if (isPaused)
            {
                ResumeGame();
            }
        }
    }

    private void ResumeGame()
    {
        Time.timeScale = 1; // Define o tempo de volta para 1 para retomar a cena.
        isPaused = false;
    }
}