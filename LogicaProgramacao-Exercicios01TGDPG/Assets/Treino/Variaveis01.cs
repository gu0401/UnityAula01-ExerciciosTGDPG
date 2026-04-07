using UnityEngine;

public class Variaveis01 : MonoBehaviour
{
    [SerializeField] private string aluno;
    [SerializeField] float n1 = 10f;
    [SerializeField] float n2 = 10f;
    [SerializeField] float media = 10f;
    [SerializeField] float notasnumero = 2f;

    void Start()
    {
        float c = 0f;
        c = n1 + n2;
        print("A soma das notas do " + aluno + " foi: " + c);
        
        float notafinal = 0f;
        notafinal = c / 2;
        print("A média do " + aluno + "foi: " + notafinal);

        if (notafinal >= media)
        {
            print(aluno + " passou nas provas!");
        }

        else
        { 
            print(aluno + " não atingiu a média!");
        }


    }

    void Update()
    {
        
    }
}
