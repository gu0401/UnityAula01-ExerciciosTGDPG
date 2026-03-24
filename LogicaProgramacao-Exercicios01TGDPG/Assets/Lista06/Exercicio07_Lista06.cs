using UnityEngine;

public class Exercicio07_Lista06 : MonoBehaviour
{
    /*
    7. Sistema de energia
    Peça energia:
    • Se energia > 80
    o Se energia == 100 → "Energia máxima"
    o Senão → "Energia alta"
    • Senão
    o Se energia > 40 → "Energia média"
    o Senão → "Energia baixa" 
    */

    [SerializeField] int energia;

    void Start()
    {
        if(energia > 80)
        {
            if(energia == 100)
            {
                print("ENERGIA MÁXIMA");
            }
            else
            {
                print("Energia alta");
            }
        }
        else
        {
            if(energia > 40)
            {
                print("Energia média");
            }
            else
            {
                print("Energia baixa");
            }
        }
    }

}
