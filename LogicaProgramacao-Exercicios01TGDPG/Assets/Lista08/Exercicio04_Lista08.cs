using UnityEngine;

public class Exercicio04_Lista08 : MonoBehaviour
{
    /*
        4. Armazenando nomes
    Crie um array com 5 nomes e imprima todos no Console.
    Desafio extra: peça para o usuário escolher um índice e mostre o nome correspondente.
     */

    [SerializeField] string[] nomes = new string[5];

    void Start()
    {
        print(nomes[0]);
        print(nomes[1]);
        print(nomes[2]);
        print(nomes[3]);
        print(nomes[4]);
    }

}
