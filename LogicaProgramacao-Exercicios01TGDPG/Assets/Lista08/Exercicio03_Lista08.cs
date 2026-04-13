using UnityEngine;

public class Exercicio03_Lista08 : MonoBehaviour
{
    /*
    3. Tabuada dinâmica
Crie uma variável int numero e use for para exibir a tabuada desse número de 1 a 10.
Exemplo:
5 x 1 = 5
5 x 2 = 10
...
     */
    [SerializeField] int numero;

    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            print(numero + " x " + i + " = " + (numero * i));
        }
    }
}
