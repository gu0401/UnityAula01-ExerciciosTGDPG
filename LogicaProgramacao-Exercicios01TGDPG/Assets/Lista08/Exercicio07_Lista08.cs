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
        n[1] = Random.Range(1, 101);
        n[2] = Random.Range(1, 101);
        n[3] = Random.Range(1, 101);
        n[4] = Random.Range(1, 101);
        n[5] = Random.Range(1, 101);
        n[6] = Random.Range(1, 101);
        n[7] = Random.Range(1, 101);
        n[8] = Random.Range(1, 101);
        n[9] = Random.Range(1, 101);
        n[0] = Random.Range(1, 101);

        int nsequencia = n[0];
        int npar = 0;

        for (int i = 0; i < n.Length; i++)
        {
            if (nsequencia % 2 == 0)
            {
                npar++;
            }
            nsequencia = n[i];
        }
        print("O número de pares é: " + npar);
    }
}
