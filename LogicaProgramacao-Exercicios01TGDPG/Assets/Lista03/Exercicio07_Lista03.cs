using UnityEditor;
using UnityEngine;

public class Exercicio07_Lista03 : MonoBehaviour
{
    /*
    Exercício 7 – Vida Restante do Personagem
Um personagem possui 150 pontos de vida.
Durante uma batalha ele recebeu os seguintes danos:
• Ataque do inimigo 1: 20
• Ataque do inimigo 2: 35
• Ataque do inimigo 3: 15
Problema:
Crie variáveis para a vida inicial e para os danos recebidos.
Calcule quanta vida resta ao personagem e exiba o resultado no console usando print().
    */

    public int ataque1 = 30;
    public int ataque2 = 35;
    public int ataque3 = 15;

    public int vida = 150;

    void Start()
    {
        print("Você tem " + vida + " de vida");
        print("E recebe os seguintes ataques que lhe causam dano: " + ataque1 + ", " + ataque2 + " e " + ataque3 + " de dano");
        print("E você fica com uma vida restante de: " + (vida - (ataque1 + ataque2 + ataque3)));
    }
}
