using UnityEngine;

public class Execicio09_Lista06 : MonoBehaviour
{
    /*
    9. Sistema de boss
Peça nível e equipamento:
• Se nível >= 20
o Se equipamento == "raro" → "Pronto para o boss"
o Senão → "Arriscado enfrentar o boss"
• Senão → "Muito fraco para o boss"
    */

    [SerializeField] int nivel;
    [SerializeField] string equipamento;

    void Start()
    {
    if(nivel >=20)
        { 
            if(equipamento == "raro")
            {
                print("Pronto para o Boss");
            }
            else
            {
                print("Arriscado enfrentar o Boss");
            }
        }
    else
        {
            print("Muito fraco para o Boss");
        }
    }


}
