using UnityEngine;

public class Funçao03 : MonoBehaviour
{
    /* 
    3. Função apenas com parâmetro (sem retorno)
Crie uma função que receba o nome do jogador e exiba:
"Jogador [nome] entrou na partida"
    */

    [SerializeField] string nome;

    void Start()
    {
        Jogador(nome);
    }

    void Jogador(string n)
    {
        print("Jogador " + name + " entrou na partida");
    }
}
