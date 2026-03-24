using UnityEngine;

public class Exercicio04_Lista06 : MonoBehaviour
{
    /*
    4. Classe do personagem
Peça força e mana:
• Se força > 70
o Se mana > 50 → "Paladino"
o Senão → "Guerreiro"
• Senão
o Se mana > 70 → "Mago"
o Senão → "Arqueiro" 
    */

    [SerializeField] int forca;
    [SerializeField] int mana;

    void Start()
    {
        if (forca > 70)
        {
            if(mana > 50)
            {
                print("Paladino");
            }
            else
            {
                print("Guerreiro");
            }
        }
        else
        {
            if(mana > 70)
            {
                print("Mago");
            }
            else
            {
                print("Arqueiro");
            }
        }
    }

}
