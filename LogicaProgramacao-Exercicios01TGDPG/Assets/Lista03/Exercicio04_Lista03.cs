using UnityEditor;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio04_Lista03 : MonoBehaviour
{
    /*
    Exercício 4 – Tempo de Missão
Um jogador levou os seguintes tempos para completar três partes de uma missão:
• Parte 1: 12 minutos
• Parte 2: 18 minutos
• Parte 3: 9 minutos
Problema:
Crie variáveis para armazenar os tempos de cada parte.
Calcule o tempo total da missão e exiba o resultado no console usando print().
    */

    public int missao01temp = 12;
    public int missao02temp = 18;
    public int missao03temp = 9;

    void Start()
    {
        print("O tempo total de suas missões feitas hoje é: " + (missao01temp + missao02temp + missao03temp) + " minutos");
    }
}
