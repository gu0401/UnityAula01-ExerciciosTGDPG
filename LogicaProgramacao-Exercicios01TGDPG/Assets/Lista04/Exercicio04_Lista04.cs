using UnityEngine;

public class Exercicio04_Lista04 : MonoBehaviour
{
    /*
    4. Verificação de velocidade
    Crie private float velocidade = 5f;
    Se velocidade > 10, exiba "Muito rápido!", senão "Velocidade normal".
    */

    [SerializeField] private float velocidade = 5f;

    void Start()
    {
        if (velocidade > 10f)
        {
            print("Muito rápido!!!");
        }
        else
            print("Velocidade normal");
    }
}
