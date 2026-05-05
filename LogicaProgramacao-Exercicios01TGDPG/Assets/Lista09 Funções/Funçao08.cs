using UnityEngine;

public class Funçao08 : MonoBehaviour
{

    /*
    8. Função com parâmetro e retorno
Crie uma função que receba a pontuação do jogador e retorne:
• "Iniciante" (0–50)
• "Intermediário" (51–100)
• "Avançado" (acima de 100) 
    */

    [SerializeField] int pontuacao;

    void Start()
    {
        print(classificao(pontuacao));
    }

    string classificao(int n)
    {
        if(n <= 50)
        {
            return "Iniciante";
        }
        else if(n > 50 && n <= 100)
        {
            return "Intermediário";
        }
        else if(n > 100)
        {
            return "Avançado";
        }
        return string.Empty;
    }
}
