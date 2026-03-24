using UnityEngine;

public class Exercicio01_Lista06 : MonoBehaviour
{

    /*
    1. Sistema de Level do Jogador
Peça o nível do jogador e XP:
• Se nível >= 10
o Se XP >= 1000 → "Jogador experiente"
o Senão → "Jogador em evolução"
• Senão
o Se XP >= 200 → "Jogador iniciante avançando"
o Senão → "Jogador iniciante" 
    */

    [SerializeField] int niveljogador;
    [SerializeField] int xp;

    void Start()
    {
        if (niveljogador >= 10)
        {
          if (xp >= 1000)
            {
                print("Jogador experiente");
            }
          else
            {
                print("Jogador em evolução");
            }
        }
        else
        {
            if (xp >= 200)
            {
                print("Jogador iniciante avançado");
            }
            else
            {
                print("Jogador noob");
            }
        }
    }

}
