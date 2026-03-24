using UnityEngine;

public class Exercicio08_Lista06 : MonoBehaviour
{
    /*
    8. NPC interação
Peça reputação e ouro:
• Se reputação > 70
o Se ouro > 100 → "Acesso VIP"
o Senão → "Acesso amigável"
• Senão
o Se reputação > 30 → "Neutro"
o Senão → "Hostil"
    */

    [SerializeField] int reputacao;
    [SerializeField] int ouro;

    void Start()
    {
    if(reputacao > 70)
        {
            if(ouro > 100)
            {
                print("Acesso VIP");
            }
            else
            {
                print("Acesso amigável");
            }
        }
    else
        {
            if(reputacao > 30)
            {
                print("Neutro");
            }
            else
            {
                print("Hostil");
            }
        }
    }

}
