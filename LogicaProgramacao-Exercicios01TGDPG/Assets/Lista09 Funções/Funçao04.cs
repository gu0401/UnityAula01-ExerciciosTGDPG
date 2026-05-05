using UnityEngine;

public class Funçao04 : MonoBehaviour
{
    /*
    4. Função apenas com parâmetro (sem retorno)
Crie uma função que receba um número de vidas e mostre:
"Você tem X vidas restantes"
    */

    [SerializeField] int vidasrestantes;
    void Start()
    {
        Vidas(vidasrestantes);
    }

    void Vidas(int n)
    {
        print("Você tem " + n + " vidas restantes");
    }
}
