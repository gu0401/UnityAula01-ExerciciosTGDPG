using UnityEngine;

public class Exercicio8 : MonoBehaviour
{
    public int vida = 100;
    public int dano;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Sua vida atual é: " + vida);

        dano = Random.Range(1, 100);
        print("Um inimigo surge das sombras! E o ataca! Causando: " + dano + " de dano!");
        print("Sua vida restante é: " + (vida - dano));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
