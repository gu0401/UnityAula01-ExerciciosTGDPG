using UnityEngine;

public class Exercicio02_Lista08 : MonoBehaviour
{
    /*
    2. Soma de números
Faça um script que some todos os números de 1 a 100 e mostre o resultado no Console.
Desafio extra: mostre também a média desses números.
     */

    int total = 0;
    float media = 0f;
    int n = 1;

    void Start()
    {
        for(int n = 1; n <= 100;  n++)
            {
            total = total + n;
            }

        float media = total / 100f;

        print("Soma total: " + total);
        print("Média da soma: " + media);
    }
}
