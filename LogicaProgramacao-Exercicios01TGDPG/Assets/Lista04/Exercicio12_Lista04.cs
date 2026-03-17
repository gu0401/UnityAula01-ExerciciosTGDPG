using UnityEngine;

public class Exercicio12_Lista04 : MonoBehaviour
{
    /*
    12. Verificação dupla (AND)
    Crie bool temArma = true; e bool temMunicao = false;
    Se ambos forem verdadeiros, exiba "Pode atirar".
    */

    [SerializeField] private bool temArma = true;
    [SerializeField] private bool temMunicao = false;

    void Start()
    {
        if (temArma & temMunicao == true)
        {
            print("Pode Atirar!");
        }
        else
            print("Não é possível atirar");
    }
}
