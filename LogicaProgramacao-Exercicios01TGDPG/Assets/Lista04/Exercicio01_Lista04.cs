using System;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Exercicio01_Lista04 : MonoBehaviour
{
    /*
    1. Vida do personagem
    Crie um script com uma variável public int vida = 100;.
    Use um if para verificar: se a vida for menor ou igual a 0, exiba "Game Over" no
    console.
    */

    public int vida = 100;

    void Start()
    {
        if (vida > 0)
        {
            print("Você está no jogo");
        }
        else
            print("Você morreu!");
    }
}
