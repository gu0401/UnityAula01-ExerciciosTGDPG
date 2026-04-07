using UnityEngine;

public class Exercicio01_ListaWhile : MonoBehaviour
{

    /*
Nível 1 – Básico
1. Crie um while que imprima números de 0 até 10 no console.
2. Faça um while que conte de 10 até 0 (contagem regressiva).
3. Crie uma variável energia = 5
Use while para diminuir a energia até chegar em 0, exibindo o valor.
4. Faça um while que mostre apenas números pares de 0 a 20. 
    */

    [SerializeField] int b = 10;
    [SerializeField] int y = 0;
    int count = 0;

    void Start()
    {
        int a = 0;
        while (a <= b)
        {
            print(a);
            a++;
        }

        int x = 10;
        while (x >= y)
        {
            print(x);
            x = x - 1;
        }

        int energia = 5;
        while (energia > 0)
        {
            print("Energia restante: " + energia);
            energia = energia - 1;
        }

        while (count <= 20)
        {
            if (count % 2 == 0)
            { 
                print(count);
            }
            count++;
        }
    }
}
