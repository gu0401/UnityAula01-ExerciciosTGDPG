using UnityEngine;

public class Exercicio10_Lista06 : MonoBehaviour
{
    /*
    10. Ranking de partida
Peça pontuação:
• Se pontuação > 1000
o Se pontuação > 2000 → "S+"
o Senão → "S"
• Senão
o Se pontuação > 500 → "A"
o Senão → "B" 
    */

    [SerializeField] int pontuacao;

    void Start()
    {
        if(pontuacao > 1000)
        {
            if(pontuacao >2000)
            {
                print("S+");
            }
            else
            {
                print("S");
            }
        }
        else
        {
            if(pontuacao > 500)
            {
                print("A");
            }
            else
            {
                print("B");
            }
        }
    }

}
