using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Exercicio03_Lista03 : MonoBehaviour
{
    /*
    Exercício 3 – Consumo de Mana
Um mago possui 100 de mana.
Ele utilizou três magias:
• Bola de fogo: 30 de mana
• Raio elétrico: 20 de mana
• Escudo mágico: 25 de mana
Problema:
Crie variáveis para a mana inicial e para o custo de cada magia.
Calcule quanta mana resta após lançar todas as magias e mostre no console usando print()
    */

    public int mana = 100;
    public int fogo = 30;
    public int eletrico = 20;
    public int escudo = 25;

    void Start()
    {
        print("Você possui " + mana + " de mana, mago implacavel!");
        print("E usa as seguintes magias... Bola de fogo - " + fogo + " de mana, Raio elétrico - " + eletrico + " de mana, e o Escudo mágico! -" + escudo + " de mana");
        print("O restante de mana que você tem é - " + (mana -(fogo + eletrico + escudo)) + " de mana -");
    }

}
