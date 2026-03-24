using UnityEngine;

public class Exercicio03_Lista06 : MonoBehaviour
{
    /*
    3. Sistema de vida
    Peça HP:
    • Se HP > 70
    o Se HP == 100 → "Vida cheia"
    o Senão → "Saudável"
    • Senão
    o Se HP > 30 → "Ferido"
    o Senão → "Crítico" 
    */

    [SerializeField] int hp;
    void Start()
    {
        if(hp >70)
        {
            if(hp == 100)
            {
                print("Vida cheia");
            }
            else
            {
                print("Saudável");
            }
        }
        else
        {
            if (hp > 30)
            {
                print("Ferido");
            }
            else
            {
                print("Crítico");
            }
        }
    }


}
