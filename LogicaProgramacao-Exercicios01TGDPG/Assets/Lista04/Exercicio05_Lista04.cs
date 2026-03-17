using UnityEngine;

public class Exercicio05_Lista04 : MonoBehaviour
{
    /*
    5. Sistema de energia
    Crie [SerializeField] private int energia = 30;
    Se energia for menor que 20, exiba "Sem energia suficiente".
    */

    [SerializeField] private int energia = 30;

    void Start()
    {
        if (energia < 20)
        {
            print("Sem energia suficiente para prosseguir");
        }
        else
            print("Com energia suficiente para prosseguir");
    }
}
