using UnityEngine;

public class Exercicio06_Lista08 : MonoBehaviour
{
    [SerializeField] private float[] notas = new float[4];

    void Start()
    {
        float notafinal = 0.0f;
          for(int i = 0; i < notas.Length; i++)
        {
            notafinal += notas[i];
        }
        print("Média final:" + (notafinal / notas.Length));

        if(notafinal / notas.Length >= 7)
        {
            print("Aprovado!");
        }
        else
        {
            print("Reprovado");
        }
    }
}
