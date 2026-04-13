using UnityEngine;

public class Exercicio02_Lista08 : MonoBehaviour
{
    /*
    2. Soma de números
Faça um script que some todos os números de 1 a 100 e mostre o resultado no Console.
Desafio extra: mostre também a média desses números.
     */

    [SerializeField] int total = 0;
    [SerializeField] float media = 0f;

    void Start()
    {
        for(int n = 0; n <= 100;  n++)
            {
            total = total + n;
            
            }

        float media = total / 100f;
        print("Soma total: " + total);
        print("Média da soma: " + media);
    }
}
