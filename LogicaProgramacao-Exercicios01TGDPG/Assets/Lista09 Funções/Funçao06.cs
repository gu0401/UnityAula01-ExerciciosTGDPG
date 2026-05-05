using UnityEngine;

public class Funçao06 : MonoBehaviour
{
    /*
    6. Função apenas com retorno (sem parâmetro)
Crie uma função que retorne o nome padrão de um personagem.
    */

    void Start()
    {
        print(NomePadrao());
    }

    string NomePadrao()
    {
        string cavaleiro = "Sem nome";
        return cavaleiro;
    }
}
