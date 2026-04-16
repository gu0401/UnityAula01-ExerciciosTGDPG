using UnityEngine;

public class Exercicio09_Lista08 : MonoBehaviour
{
    [SerializeField] private string[] alunos = new string[] { "Michu", "Teto", "Godzilla" };
    [SerializeField] private float[] notas = new float[] { 9.0f, 5.0f, 8.5f };

    void Start()
    {
        for (int i = 0; i < alunos.Length; i++)
        {
            print(alunos[i] + " sua nota é, " + notas[i]);

            if (notas[i] >= 9)
            {
                print(alunos[i] + " excelente!");
            }
            else if (notas[i] >= 7.0f && notas[i] <= 8.0)
            {
                print(alunos[i] + " muito bom!");
            }
            else if (notas[i] >= 0 && notas[i] <= 6.0f)
            {
                print(alunos[i] + " reprovado");
            }
        }
    }


}
