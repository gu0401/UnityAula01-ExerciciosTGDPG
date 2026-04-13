using System.Threading;
using UnityEngine;

public class Exercicio02_ListaWhile : MonoBehaviour
{
    /*
    5. Mostre números de 1 a 20, mas:
o Se for múltiplo de 3, escreva "Fizz"
o Caso contrário, mostre o número
6. Crie um sistema de vidas:
int vidas = 3;
• Enquanto vidas > 0, mostre "Jogador vivo"
• Quando chegar a 0, mostre "Game Over"
7. Simule um contador de moedas:
• Comece com 0 moedas
• Enquanto moedas < 10
• Some +1 por loop
• Se moedas == 5, mostre "Metade do caminho!" 
    */

    [SerializeField] int count = 0;
    [SerializeField] int vida = 3;

    void Start()
    {
        while (count <= 20)
        {
            if (count % 3 == 0)
            {
                print("Fizz: " + count);
            }
            else
            {
                print(count);
            }
            count++;
        }

        while (vida >= 0)
        {
            print("Jogador vivo");
            vida--;
        }
        print("Game over");

        int moedas = 0;
        while (moedas <= 10)
        {
            if (moedas == 5)
            {
                print("Metade do caminho, " + moedas + " moedas");
            }

            else
            {
                print(moedas + " moeda(s) atuais");
            }
            moedas++;
        }
    }
}
