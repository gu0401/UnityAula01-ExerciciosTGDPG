using UnityEngine;

public class Funçao05 : MonoBehaviour
{
    /*
    5. Função apenas com retorno (sem parâmetro)
Crie uma função que retorne um número fixo de moedas iniciais (ex: 100
    */

    void Start()
    {
        print(MoedasFixo());
    }


    int MoedasFixo()
    {
        int moedasiniciais = 100; 
        return moedasiniciais;
    }
}
