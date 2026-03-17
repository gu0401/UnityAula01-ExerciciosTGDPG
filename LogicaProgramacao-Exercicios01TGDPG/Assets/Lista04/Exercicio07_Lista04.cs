using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Exercicio07_Lista04 : MonoBehaviour
{
    /*
    7. Porta aberta
    Crie bool temChave = false;
    Se temChave == true, exiba "Porta aberta" senão "Porta trancada".
    */


    [SerializeField] private bool temChave = false;

    void Start()
    {
        if (temChave == true)
        {
            print("Humm, você tem a chave, a porta se abre");
        }
        else
            print("Falta a CHAVE!");
    }
}
