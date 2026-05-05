using UnityEngine;

public class Funçao09 : MonoBehaviour
{
    /*
    9. Desafio (misto)
Crie:
• Uma função sem parâmetro que inicia o jogo (exibe mensagem)
• Uma função com parâmetro que recebe o nome do jogador
• Uma função com retorno que define a pontuação inicial 
    */

    [SerializeField] string nome;
    [SerializeField] int pontosiniciais;

    void Start()
    {
        Inicio();
        Jogador(nome);
        print(pontuacao(pontosiniciais) + " ponto(s)");
    }


    void Inicio()
    {
        print("Jogo iniciado");
    }

    void Jogador(string n)
    {
        print("Nome do jogador: " + n);
    }

    int pontuacao(int n)
    {
        return pontosiniciais;
    }


}
