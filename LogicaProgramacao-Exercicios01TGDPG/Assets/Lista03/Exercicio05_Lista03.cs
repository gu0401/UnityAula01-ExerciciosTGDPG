using UnityEngine;

public class Exercicio05_Lista03 : MonoBehaviour
{
    /*
    Exercício 5 – Coleta de Moedas
Durante uma fase o jogador coletou:
• 12 moedas de bronze (valor 1)
• 8 moedas de prata (valor 5)
• 3 moedas de ouro (valor 10)
Problema:
Crie variáveis para as quantidades e valores das moedas.
Calcule o valor total coletado e imprima no console usando print().
    */

    public int bronze = 12;
    public int prata = 8;
    public int ouro = 3;
    public int valor1 = 1;
    public int valor2 = 5;
    public int valor3 = 10;
        
    void Start()
    {
        print("Você coletou " + bronze + " moedas de bronze! Cada uma vale "+ valor1 + " pontos!");
        print("Você coletou " + prata + " moedas de prata! Cada uma vale " + valor2 + " pontos!");
        print("Você coletou " + ouro + " de ouro! Cada uma vale " + valor3 + " pontos!");
        print("O seu total de pontos foi: " + (bronze * valor1) + (prata * valor2) + (ouro * valor1) + " pontos!");
    }
}
