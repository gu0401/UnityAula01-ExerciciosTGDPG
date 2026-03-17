using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class Exercicio03_Lista04 : MonoBehaviour
{
    /*
    3. Sistema de pontuação
    Crie public int pontos;
    Se pontos forem maiores que 100, mostre "Você venceu!".
    */

    public int pontos;
    
    void Start()
    {
        if (pontos > 100)
        {
            print("Você ganhou!!! Acima de 100 pontos é contado como vitória!");
        }
        else
            print("Você perdeu! Está com menos que 100 pontos...");
    }
}
