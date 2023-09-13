using UnityEngine;
using TMPro;

public class SystemBox : MonoBehaviour
{
    public int objetosDentro = 0;
    public int objetosNecessarios = 5;

    public TextMeshProUGUI textoContagem; // Referência ao objeto TextMeshPro

    public Canvas canvasParaAtivar; // Arraste o objeto Canvas aqui no Inspector

    private void OnTriggerEnter(Collider other)
    {
        // Verifique se o objeto que entrou na caixa possui a tag "ObjetoContavel".
        if (other.CompareTag("ObjetoContavel"))
        {
            objetosDentro++;

            AtualizarTextoContagem();

            // Verifique se o número de objetos dentro da caixa é igual ao número necessário.
            if (objetosDentro >= objetosNecessarios)
            {
                // A caixa está completa, ative o Canvas.
                canvasParaAtivar.gameObject.SetActive(true);

                Debug.Log("Caixa Completa!");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Verifique se o objeto que saiu da caixa possui a tag "ObjetoContavel".
        if (other.CompareTag("ObjetoContavel"))
        {
            objetosDentro--;
        }

        AtualizarTextoContagem();
    }

    private void AtualizarTextoContagem()
    {
        // Atualize o texto com a contagem atual e total
        textoContagem.text = "Pegou: " + objetosDentro + " / Total: " + objetosNecessarios;
    }
}