using UnityEngine;

public class Exercicio07_Lista08 : MonoBehaviour
{
    /*
    7. Contar números pares
Crie um array com 10 números inteiros e use um for para percorrer o vetor.
Conte quantos números são pares e mostre o resultado
    */

    [SerializeField] int[] n = new int[10];

    void Start()
    {
        int nsequencia = n[0];
        int npar = 0;

        for (int i = 0; i < n.Length; i++)
        {
            n[i] = Random.Range(1, 100);
            if (nsequencia % 2 == 0)
            {
                npar++;
            }
            nsequencia = n[i];
        }
        print("O número de pares é: " + npar);
    }
}
