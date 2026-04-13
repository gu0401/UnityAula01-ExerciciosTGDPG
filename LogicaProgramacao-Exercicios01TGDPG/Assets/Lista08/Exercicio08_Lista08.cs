using UnityEngine;

public class Exercicio08_Lista08 : MonoBehaviour
{
    /*
    8. Sistema de inventário simples
Crie dois arrays:
• string[] itens
• int[] quantidades
Use um for para mostrar todos os itens e suas quantidades.
Use if para avisar quando algum item estiver com quantidade menor que 5:
"Item X está com estoque baixo!"
    */

    [SerializeField] string[] itens = new string[5];
    [SerializeField] int[] quantidades = new int[5];

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            print("Item: " + itens[i] + " - Quantidade: " + quantidades[i]);
        }
    }


}
