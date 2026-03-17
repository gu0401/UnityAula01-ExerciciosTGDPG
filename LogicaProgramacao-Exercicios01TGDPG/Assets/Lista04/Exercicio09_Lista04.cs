using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class Exercicio09_Lista04 : MonoBehaviour
{
    /*
    9. Sistema de moedas
    Crie[SerializeField] private int moedas = 50;
    Se moedas >= 100, exiba "Pode comprar item".
    */

    [SerializeField] private int moedas = 50;
    void Start()
    {
        if (moedas >= 100)
        {
            print("Consegue comprar o item");
        }
        else
            print("Moedas insuficientes");
    }
}
