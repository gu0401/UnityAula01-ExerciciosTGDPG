using UnityEngine;

public class Exercicio08_Lista04 : MonoBehaviour
{
    /*
    8. Comparação de níveis
    Crie int nivelJogador = 5; e int nivelInimigo = 8;
    Se jogador >= inimigo, exiba "Pode lutar", senão "Muito perigoso"
    */

    [SerializeField] private int nivelJogador = 5;
    [SerializeField] private int nivelInimigo = 8;

    void Start()
    {
        if (nivelJogador >= nivelInimigo)
        {
            print("Você pode enfrentar o inimigo!");
        }
        else
            print("Inimigo muito perigoso para o seu nível");
    }
}
