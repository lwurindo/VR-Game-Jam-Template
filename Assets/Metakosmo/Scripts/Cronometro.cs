using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cronometro : MonoBehaviour
{
    public TextMeshProUGUI textoCronometro;
    public float tempoTotal = 300f; // 300 segundos (5 minutos)
    private float tempoRestante;
    private bool cronometroAtivo = true;

    public Canvas canvasDerrota; // Arraste o objeto Canvas aqui no Inspector

    private void Start()
    {
        tempoRestante = tempoTotal;
    }

    private void Update()
    {
        if (cronometroAtivo)
        {
            tempoRestante -= Time.deltaTime;

            if (tempoRestante <= 0)
            {
                tempoRestante = 0;
                cronometroAtivo = false;
                MostrarCanvasDerrota();
            }

            AtualizarTextoCronometro();
        }
    }

private void MostrarCanvasDerrota()
{
    // Ative o Canvas de derrota que está desativado por padrão.
    canvasDerrota.gameObject.SetActive(true);
}

    private void AtualizarTextoCronometro()
    {
        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos = Mathf.FloorToInt(tempoRestante % 60);
        textoCronometro.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }

    // Você pode adicionar uma função para parar o cronômetro quando a fase for completada.
    public void PararCronometro()
    {
        cronometroAtivo = false;
    }
}
