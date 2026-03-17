using UnityEngine;

public class Exercicio10_Lista04 : MonoBehaviour
{
    /*
       10. Tempo de jogo
       Crie float tempo = 120f;
       Se tempo <= 0, exiba "Tempo esgotado".
    */

    [SerializeField] private float tempo = 120f;

    void Start()
    {
        if (tempo < 0)
        {
            print("Tempo esgotado!");
        }
        else
            print("Jogo rolando");
    }
}
