using UnityEngine;

public class SuperTrunfo : MonoBehaviour
{
    /*
Exercício: Super Trunfo (Simplificado)
Regras:
• Existem cartas com atributos
• Cada jogador recebe uma carta aleatória por rodada
• O jogo tem 5 rodadas
• Em cada rodada:
o Um atributo é sorteado (ex: força, velocidade ou inteligência)
o Quem tiver o maior valor vence a rodada
• No final:
o Mostrar o vencedor ou empate
    */

    /* 0 - força
     * 1 - velocidade
     * 2 - inteligência
     */

    int[] cartajogador1 = new int[3];
    int[] cartajogador2 = new int[3];

    int pontos1;
    int pontos2;

    int rodadas;
    int atributo;

    private void Start()
    {
        // REGISTRA A RODADA
        rodadas = 0;

        //Sorteia o Atributo para a rodada atual - 0 = força - 1 = velocidade - 2 = inteligência
        atributo = Random.Range (0,3);


        
    }

    void Update()
    {
        if (Input.anyKeyDown && rodadas < 5)
        {
            //Registra a rodada
            rodadas++;

            atributo = Random.Range(0, 3);

            // Sorteia a carta dos jogadores - atributos das cartas com valores de 1 até 9
            for (int i = 0; i < 3; i++)
            {
                cartajogador1[i] = Random.Range(1, 10);
                cartajogador2[i] = Random.Range(1, 10);
            }

            //Definir  o resultado da rodada
            if (atributo == 0)
            {

                //força
                if (cartajogador1[0] == cartajogador2[0])
                {
                    print("Empate");
                }
                else
                {
                    if (cartajogador1[0] > cartajogador2[0])
                    {
                        print("Jogador 1 ganhou a rodada. +1 ponto - Pontos atuais = " + pontos1);
                        pontos1++;
                    }
                    else
                    {
                        print("Jogador 2 ganhou a rodada. +1 ponto - Pontos atuais = " + pontos2);
                        pontos2++;
                    }
                }

                //velocidade
                if (cartajogador1[1] == cartajogador2[1])
                {
                    print("Empate");
                }
                else
                {
                    if (cartajogador1[1] > cartajogador2[1])
                    {
                        print("Jogador 1 ganhou a rodada. +1 ponto - Pontos atuais = " + pontos1);
                        pontos1++;
                    }
                    else
                    {
                        print("Jogador 2 ganhou a rodada. +1 ponto - Pontos atuais = " + pontos2);
                        pontos2++;
                    }
                }

                //inteligência
                if (cartajogador1[2] == cartajogador2[2])
                {
                    print("Empate");
                }
                else
                {
                    if (cartajogador1[2] > cartajogador2[2])
                    {
                        print("Jogador 1 ganhou a rodada. +1 ponto - Pontos atuais = " + pontos1);
                        pontos1++;
                    }
                    else
                    {
                        print("Jogador 2 ganhou a rodada. +1 ponto - Pontos atuais = " + pontos2);
                        pontos2++;
                    }
                }

                //RESULTADO
                if (atributo == 0)
                {
                    print("Atributo: força");
                }
                else if (atributo == 1)
                {
                    print("Atributo: velocidade");
                }
                else if (atributo == 2)
                {
                    print("Atributo: inteligência");
                }

                //Exibe o valor da carta
                print("Carta do jogador 1: " + cartajogador1[atributo]);
                print("Carta do jogador 2: " + cartajogador2[atributo]);

                //Pontuação atual
                print("Jogador 1:" + pontos1);
                print("Jogador 2:" + pontos2);
                print("--------------------");
            }
            else if (rodadas == 5)
            {
                
                rodadas++;

                if (pontos1 == pontos2)
                {
                    print("EMPATE, WOW");
                }
                else if (pontos1 > pontos2)
                {
                    print("O jogador 1 venceu o jogo!");
                }
                else
                {
                    print("O jogador 2 venceu o jogo!");
                }
            }
        }
    }
}
