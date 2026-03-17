using UnityEngine;

public class Exercicio02_Lista04 : MonoBehaviour
{
    /* 2. Dano recebido
    Crie uma variável [SerializeField] private int dano = 10; e subtraia de vida.
    Se a vida ficar abaixo de 50, mostre "Cuidado!".
    */
    [SerializeField] private int dano = 10;
    [SerializeField] private int vida = 100;
    void Start()
    {
        if (vida < 50)
        {
            print("CUIDADO");
        }
        else
            print("Suave");
    }
}
