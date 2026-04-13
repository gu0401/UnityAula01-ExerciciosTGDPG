using UnityEngine;

public class Exercicio05_Lista08 : MonoBehaviour
{

    /*
    5. Maior número do array
Crie um array com 10 números inteiros (valores definidos no código) e descubra qual é
o maior número.
    */

    [SerializeField] int[] numeros = { 100, 99, 333, 222, 999, 777, 555, 909, 241, 67 };

    void Start()
    {
        int maior = numeros[0];

        for (int i = 0;  i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }
        print("O maior número é: " + maior);
    }
}
