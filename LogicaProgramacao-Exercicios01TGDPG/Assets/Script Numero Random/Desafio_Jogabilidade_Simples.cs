using UnityEngine;

public class Desafio_Jogabilidade_Simples : MonoBehaviour
{
    private int numerosorteado;
    [SerializeField] private int palpite;
    [SerializeField] private int tentativa;
    private int tentativa2;

    void Start()
    {
        tentativa = 4;
        tentativa2 = 3;
        numerosorteado = Random.Range(1, 101);
        print("Bem-vindo ao jogo!");
        print("Adivinhe o número sorteado de: 1 a 100, você tem 3 tentativas");
        print("Clicando no canto direito superior escolha o número e clique na tela para iniciar o jogo!");
        if (numerosorteado >= 0 && numerosorteado <= 30)
        {
            print("Dica. O número sorteado está entre 0 e 30");
        }
        else if (numerosorteado >= 30 && numerosorteado <= 60)
        {
            print("Dica. O número sorteado está entre 30 e 60");
        }
        else if (numerosorteado >= 60 && numerosorteado <= 90)
        {
            print("Dica. O número sorteado está entre 60 e 90");
        }
        else if (numerosorteado >= 90 && numerosorteado <= 100)
        {
            print("WOW Dica suprema! O número está entre 90 e 100");
        }

    }
    void Update()
    {

        if (Input.anyKeyDown)
        {
            tentativa = tentativa - 1;
            tentativa2 = tentativa2 - 1;


            if (tentativa > 0)
            {
                if (numerosorteado > palpite)
                {
                    print("O seu palpite foi " + palpite + ", mas está menor que o número sorteado! Restam " + tentativa2 + " tentativa(s)");
                }
                else if (numerosorteado < palpite)
                {
                    print("O seu palpite foi " + palpite + ", mas está maior que o número sorteado! Restam " + tentativa2 + " tentativa(s)");
                }
                else
                {
                    print("Você acertou o número sorteado com seu palpite, sortudo! : " + numerosorteado + " sendo o número sorteado");
                }
            }
            else
            {
                print("Suas tentativas se esgotaram, " + numerosorteado + " era o número sorteado. Reinicie o jogo");
            }
        }
        

    }
}
