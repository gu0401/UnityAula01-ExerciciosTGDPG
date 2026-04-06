using UnityEngine;

public class Jankenpo : MonoBehaviour
{
     int escolhacpu;
    [SerializeField] bool tesoura;
    [SerializeField] bool papel;
    [SerializeField] bool pedra;
     int pontosjogador = 0;
     int pontoscpu = 0;

    void Start()
    {
        
        print("Seja bem vindo a uma partida de Jankenpô");
        print("Escolha uma das opções no canto superior direito da tela e clique em qualquer tecla para iniciar!");
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            // Na escolha da CPU o 1 significa pedra, o 2 papel e o 3 tesoura
            escolhacpu = Random.Range(1, 4);

            //Sistema que determina se o jogador escolheu mais ou menos que uma opção, dentro dos limites do jogo
            if (pedra == false && papel == false && tesoura == false)
            {
                print("Escolha pelo menos uma opção!");
            }
            else if (pedra == true && papel == true && tesoura == true)
            {
                print("Escolha apenas uma única opção!");
            }
            else if (pedra == false && papel == true && tesoura == true)
            {
                print("Escolha apenas uma única opção!");
            }
            else if (pedra == true && papel == false && tesoura == true)
            {
                print("Escolha apenas uma única opção!");
            }
            else if (pedra == true && papel == true && tesoura == false)
            {
                print("Escolha apenas uma única opção!");
            }

            //Sistema que declara quem venceu
            if (pontosjogador >= 3)
            {
                print("Você venceu a partida");
            }
            else if (pontoscpu >= 3)
            {
                print("Game Over, CPU venceu");
            }
            else
            {

            //Caso o jogador escolha pedra
            if (pedra == true && papel == false && tesoura == false)
                {
                    if (pedra == true && escolhacpu == 3)
                    {
                        print("Você escolheu pedra e a CPU escolheu tesoura! Logo...");
                        pontosjogador = pontosjogador + 1;
                        print("Você ganhou uma rodada!");
                        print("Sua pontuação atual: " + pontosjogador + " pontos(s) - Pontuação da CPU: " + pontoscpu + " pontos(s)");
                    }
                    else if (pedra == true && escolhacpu == 1)
                    {
                        print("Você escolheu pedra e a CPU também escolheu! Logo...");
                        print("Deu empate!");
                        print("Sua pontuação atual: " + pontosjogador + " pontos(s) - Pontuação da CPU: " + pontoscpu + " pontos(s)");
                    }
                    else if (pedra == true && escolhacpu == 2)
                    {
                        print("Você escolheu pedra e a CPU escolheu papel! Logo...");
                        print("Você perdeu a rodada! Fazendo assim a CPU ganhar um ponto");
                        pontoscpu = pontoscpu + 1;
                        print("Sua pontuação atual: " + pontosjogador + " pontos(s) - Pontuação da CPU: " + pontoscpu + " pontos(s)");
                    }
                }

            //Caso o jogador escolha papel
            else if (pedra == false && papel == true && tesoura == false)
                {
                    if (papel == true && escolhacpu == 1)
                    {
                        print("Você escolheu papel e a CPU escolheu pedra! Logo...");
                        pontosjogador = pontosjogador + 1;
                        print("Você ganhou uma rodada!");
                        print("Sua pontuação atual: " + pontosjogador + " pontos(s) - Pontuação da CPU: " + pontoscpu + " pontos(s)");
                    }
                    else if (papel == true && escolhacpu == 2)
                    {
                        print("Você escolheu papel e a CPU também escolheu! Logo...");
                        print("Deu empate!");
                        print("Sua pontuação atual: " + pontosjogador + " pontos(s) - Pontuação da CPU: " + pontoscpu + " pontos(s)");
                    }
                    else if (papel == true && escolhacpu == 3)
                    {
                        print("Você escolheu papel e a CPU escolheu tesoura! Logo...");
                        print("Você perdeu a rodada! Fazendo assim a CPU ganhar um ponto");
                        pontoscpu = pontoscpu + 1;
                        print("Sua pontuação atual: " + pontosjogador + " pontos(s) - Pontuação da CPU: " + pontoscpu + " pontos(s)");
                    }
                }

                //Caso o jogador escolha tesoura
            else if (pedra == false && papel == false && tesoura == true)
                {
                    if (tesoura == true && escolhacpu == 2)
                    {
                        print("Você escolheu tesoura e a CPU escolheu papel! Logo...");
                        pontosjogador = pontosjogador + 1;
                        print("Você ganhou uma rodada!");
                        print("Sua pontuação atual: " + pontosjogador + " pontos(s) - Pontuação da CPU: " + pontoscpu + " pontos(s)");
                    }
                    else if (tesoura == true && escolhacpu == 3)
                    {
                        print("Você escolheu tesoura e a CPU também escolheu! Logo...");
                        print("Deu empate!");
                        print("Sua pontuação atual: " + pontosjogador + " pontos(s) - Pontuação da CPU: " + pontoscpu + " pontos(s)");
                    }
                    else if (tesoura == true && escolhacpu == 1)
                    {
                        print("Você escolheu tesoura e a CPU escolheu pedra! Logo...");
                        print("Você perdeu a rodada! Fazendo assim a CPU ganhar um ponto");
                        pontoscpu = pontoscpu + 1;
                        print("Sua pontuação atual: " + pontosjogador + " ponto(s) - Pontuação da CPU: " + pontoscpu + " ponto(s)");
                    }
                }
            }

            
           
        }
    }
}
