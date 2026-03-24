using UnityEngine;

public class Exercicio02_Lista06 : MonoBehaviour
{
    /*
    2. Ataque em combate
    Peça se tem arma e força:
    • Se tem arma
    o Se força > 50 → "Ataque forte"
    o Senão → "Ataque médio"
    • Senão
    o Se força > 50 → "Ataque improvisado forte"
    o Senão → "Ataque fraco"
    */

    [SerializeField] bool arma;
    [SerializeField] int forca;

    void Start()
    {
        if(arma == true)
        {
            if(forca > 50)
            {
                print("Ataque forte");
            }
            else
            {
                print("Ataque médio");
            }
        
        }
        else
        {
            if(forca > 50)
            {
                print("Ataque improvisado forte");
            }
            else
            {
                print("Ataque fraco");
            }
        }

    }

}
