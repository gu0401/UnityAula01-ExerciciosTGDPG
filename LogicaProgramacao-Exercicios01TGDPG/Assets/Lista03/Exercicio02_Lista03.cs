using System;
using UnityEngine;

public class Exercicio02_Lista03 : MonoBehaviour
{
    /*
    Exercício 2 – Dano Total do Ataque
Um personagem possui um ataque que causa 15 de dano base.
Durante o combate aconteceram os seguintes bônus:
• Um bônus de arma que adiciona 5 de dano
• Um bônus temporário que multiplica o dano por 2
Problema:
Crie variáveis para os valores do dano base e dos bônus.
Calcule o dano final do ataque e imprima o resultado no console usando print().
    */

    int personagemdano = 15;
    int bonusencantamento = 5;
    int bonustemp = 2;

    void Start()
    {
        print("Você decide ir a uma luta com uma espada que causa " + personagemdano + " de dano, com um encantamento de afiação 1 (Que aumenta o seu dano para " + (personagemdano + bonusencantamento) + ") e toma uma poção de dano temporário, ficando com " + ((personagemdano + bonusencantamento) * bonustemp) + " de dano");
    }
}
