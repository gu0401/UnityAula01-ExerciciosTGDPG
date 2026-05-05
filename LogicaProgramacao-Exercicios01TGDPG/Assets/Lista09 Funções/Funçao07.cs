using UnityEngine;

public class Funçao07 : MonoBehaviour
{
    /*
    7. Função com parâmetro e retorno
Crie uma função que receba dois números (ataque e defesa) e retorne o dano final
(ataque - defesa).
    */

    [SerializeField] int ataque;
    [SerializeField] int defesa;

    void Start()
    {
        print(Danofinal(ataque, defesa));
    }

    int Danofinal(int z, int x)
    {
        return z - x;
    }
}
