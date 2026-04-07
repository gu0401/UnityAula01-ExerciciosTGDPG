using UnityEngine;

public class Exercicio03_ListaWhile : MonoBehaviour
{
/*
8. Crie um while que some números de 1 até 100 e mostre o total final.
9. Faça um sistema que pare quando encontrar um número específico:
• Comece em 0
• Vá somando +1
• Se o número for 7, pare o loop (break)
10. Crie um loop que:
• Vai de 1 até 20
• Se o número for par, imprime "Par"
• Se for ímpar, imprime "Ímpar"
*/

    [SerializeField] int n1;
    [SerializeField] int total;

    [SerializeField] int n2 = 0;

    void Start()
    {
        while (n1 <= 100)
        {
            total = total + n1;
            n1++;
        }
        print(total + " é o total");

        while (n2 < 100)
        {
            print(n2);
            n2++;
            if(n2 > 7)
            {
                break;
            }
        }

        int n3 = 1;
        while (n3 <= 20)
        {
            if (n3 % 2 == 0)
            {
                print(n3 + " é um número par");
            }
            else
            {
                print(n3 + " é um número ímpar");
            }
            n3++;
        }
    }
}
