using UnityEngine;

public class Exercicio11_Lista04 : MonoBehaviour
{
    /*
    11. Sistema de pulo
    Crie bool estaNoChao = true;
    Se estiver no chão, exiba "Pode pular"
    */

    [SerializeField] private bool estaNoChao = true;

    void Start()
    {
        if (estaNoChao == true)
        {
            print("Consegue pular!");
        }
        else
            print("Não consegue pular");
    }
}
