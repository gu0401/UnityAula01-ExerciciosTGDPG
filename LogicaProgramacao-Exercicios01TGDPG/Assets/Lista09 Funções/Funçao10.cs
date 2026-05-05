using UnityEngine;

public class Funçao10 : MonoBehaviour
{
    /*
    10. Desafio completo (simulação de jogo)
Monte um pequeno sistema com funções:
• Exibir HUD (sem parâmetro, sem retorno)
• Receber dano (com parâmetro, sem retorno)
• Calcular nível (com parâmetro e retorno)
• Obter pontuação inicial (sem parâmetro, com retorno)
    */

    [SerializeField] int Dano;
    [SerializeField] int nivel;
    [SerializeField] int xp;

    void Start()
    {
        HUD();
        danorecebido(Dano);
        print("Nível: " + calculonivel(nivel, xp));
        xpinicial();
    }

    void HUD()
    {
        print("Exibindo HUD");
    }

    void danorecebido(int n)
    {
        print("Dano recebido: " + n);
    }

    int calculonivel(int nvl, int xp)
    {
       if(xp >= 10)
        {
            return nivel + 1;
        }
       else if (xp >= 20)
        {
            return nivel + 2;
        }
       else
        {
            return nivel;
        }
    }

    void xpinicial()
    {
        int xp = 5;
        print("XP inicial é: " + xp);
    }
}
