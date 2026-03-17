using UnityEngine;

public class Exercicio13_Lista04 : MonoBehaviour
{
    /*
    13. Verificação alternativa (OR)
    Crie bool temChave = false; e bool portaDestravada = true;
    Se um dos dois for verdadeiro, exiba "Acesso permitido".
    */

    [SerializeField] private bool temChave = false;
    [SerializeField] private bool portaDestravada = true;

    void Start()
    {
        if (temChave & portaDestravada == true)
        {
            print("Acesso permitido");
        }
        else
            print("Não é possivel abrir a porta");
    }
}
