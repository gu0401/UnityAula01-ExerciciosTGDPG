using UnityEngine;

public class Exercicio06_Lista06 : MonoBehaviour
{
    /*
    6. Missão concluída
    Peça inimigos derrotados e tempo:
    • Se inimigos >= 10
    o Se tempo < 5 → "Missão perfeita"
    o Senão → "Missão completa"
    • Senão
    o Se inimigos >= 5 → "Missão parcial"
    o Senão → "Missão falhou"
    */

    [SerializeField] int inimigosderrotados;
    [SerializeField] int tempo;

    void Start()
    {
        if (inimigosderrotados >= 10)
        {
            if (tempo > 5)
            {
                print("Missão perfeita");
            }
            else
            {
                print("Missão completa");
            }
        }
        else
        {
            if (inimigosderrotados >= 5)
            {
                print("Missão parcil");
            }
            else
            {
                print("Missão falhou");
            }
        }
    }

}
