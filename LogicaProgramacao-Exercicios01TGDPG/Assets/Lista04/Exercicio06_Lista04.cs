using UnityEngine;

public class Exercicio06_Lista04 : MonoBehaviour
{
    /*
    6. Ataque crítico
    Crie int danoBase = 10; e bool critico = true;
    Se for crítico, multiplique o dano por 2.
    */

    [SerializeField] private int danoBase = 10;
    [SerializeField] private bool critico = true;

    void Start()
    {
        if (critico == true)
        {
            print((danoBase * 2) + ", hummm um critíco... isso doeu");
        }
        else
            print(danoBase + ", dano normal");
    }
}
