using UnityEngine;

public class Exercicio01_Lista08 : MonoBehaviour
{
    /*
    1. Contador simples no Console
Crie um script que imprima no Console os números de 1 a 10 usando for.
Desafio extra: mostre apenas os números pares.
     */

    void Start()
    {
        for (int n = 1; n <= 10; n++)
        {
            if (n % 2 == 0)
            {
                print(n);
            }

        }
    }


}
