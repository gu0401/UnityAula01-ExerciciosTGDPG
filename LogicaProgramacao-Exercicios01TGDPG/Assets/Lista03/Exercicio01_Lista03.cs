using UnityEngine;

public class Exercicio01_Lista03 : MonoBehaviour
{
    /*
    Exercício 1 – Pontos de Experiência do Personagem
Um personagem derrotou 3 inimigos pequenos, 2 inimigos médios e 1 inimigo chefe.
• Cada inimigo pequeno concede 10 XP.
• Cada inimigo médio concede 25 XP.
• O chefe concede 100 XP.
Problema:
Crie variáveis para armazenar a quantidade de inimigos derrotados e o XP de cada tipo.
Calcule o XP total ganho pelo personagem e mostre o resultado no console usando print().
    */

    public int inimigop = 10;
    public int inimigom = 25;
    public int boss = 100;

            
    void Start()
    {
        print("Você encontrou 3 inimigos pequenos! E então os ataca!");
        print("Derrotou os 3, ganhando - " + (inimigop * 3) + " de XP! - Parabéns!");
        print("E de repente 2 inimigos médios aparecem! Você derruba eles com sua espada brabissima!");
        print("Com eles 2 no chão você ganhou... - " + (inimigom * 2) + " de XP! - Parabéns!");
        print("Após derrotar todos os inimigos o Boss se aproxima e você o ataca com sua ult!");
        print("É um acerto crítico?! Sim isso mesmo! Você o derrota e adquire... - " + (boss * 1) + " de XP! - GG");
    }
}