using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExibirTotal : MonoBehaviour
{
    public GameObject carrinho; // O objeto do seu carrinho
    public TextMeshProUGUI textoTotal; // O componente de texto para exibir o total

    void Update()
    {
        // Supondo que o carrinho tenha um script com uma variável pública 'total'
        float total = carrinho.GetComponent<Cart>().total;

        // Atualizar o texto na tela com o valor total
        textoTotal.text = "Total: " + total.ToString();
    }
}