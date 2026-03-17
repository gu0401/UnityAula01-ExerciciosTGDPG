using System;
using Unity.VisualScripting;
using UnityEngine;

public class Exercicio06_Lista03 : MonoBehaviour
{
    /*
    Exercício 6 – Velocidade do Personagem
Um personagem percorreu 120 unidades de distância em 10 segundos.
Problema:
Crie variáveis para distância e tempo.
Calcule a velocidade média do personagem usando a fórmula:
velocidade = distancia / tempo
Mostre o resultado no console usando print().
    */

    public int distancia = 120;
    public int tempo = 10;
    public int velocidade = 0;

    void Start()
    {
        velocidade = distancia / tempo;
        print("A sua velocidade média é " + velocidade);
    }
}
