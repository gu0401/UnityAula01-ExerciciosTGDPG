using UnityEngine;

public class Exercicio05_Lista06 : MonoBehaviour
{
    /*
5. Sistema de loot
Peça raridade (1 a 3) e sorte:
• Se raridade == 3
o Se sorte > 80 → "Item lendário++"
o Senão → "Item lendário"
• Senão
o Se raridade == 2
▪ Se sorte > 50 → "Item raro bom"
▪ Senão → "Item raro comum"
o Senão → "Item comum" 
    */

    [SerializeField] int raridade;
    [SerializeField] int sorte;

    void Start()
    {
        raridade = Random.Range(1, 4);   
        if (raridade == 3)
        {
            if (sorte > 80)
            {
                print("Item lendário+++");
            }
            else
            {
                print("Item lendário");
            }
        }
        else
        {
            if (raridade == 2)
            {
                if (sorte > 50)
                {
                    print("Item raro bom");
                }
                else
                {
                    print("Item raro comum");
                }
            }
            else
            {
                print("Item comum");
            }
        }
    }

}
