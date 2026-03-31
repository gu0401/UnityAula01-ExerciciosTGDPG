using UnityEngine;

public class Desafio_Apostas_Guerreiros : MonoBehaviour
{
    [SerializeField] private int dinheiro = 100;
    [SerializeField] int dinheiroapostado;
    [SerializeField] bool guerreiroA;
    [SerializeField] bool guerreiroB;
     int atkA;
     int atkB;


    void Start()
    {

        print("Bem vindo a luta!");
        print("Escolha o seu guerreiro...");
        print("E escolha também o quanto você vai apostar! Lembre-se você têm " + dinheiro + " moedas. Todas essas escolhas estão no canto superiro direito da Unity");
        print("Clique na tela com qualquer tecla para começar as suas ações");
        
    }


    void Update()
    {
       if (Input.anyKeyDown)
        {
            atkA = Random.Range(1, 101);
            atkB = Random.Range(1, 101);

            if (dinheiro >= 500)
            {
                print("Já ta bom, não acha? ou vai tentar chegar mais alto?");
            }

            if (dinheiro == 0)
            {
                print("PERDEU, OTÁRIO");
            }


            if (dinheiroapostado <= dinheiro && dinheiroapostado > 0)
            {
                if (guerreiroA == true && guerreiroB == true)
                {
                    print("Escolha apenas um guerreiro para apostar!");
                }
                else if (guerreiroA == false && guerreiroB == false)
                {
                    print("Escolha pelo menos um guerreiro para apostar!");
                }
                else
                {
                    if (guerreiroA == true && guerreiroB == false)
                    {
                        if (atkA > atkB)
                        {
                            dinheiro = dinheiro - dinheiroapostado;
                            dinheiro = dinheiro + (dinheiroapostado * 2);
                            print("Guerreiro A venceu! Você ganhou a aposta!");
                            print("Força do Guerreiro A: " + atkA + " . Força do Guerreiro B: " + atkB);
                            print("Ganhando assim como recompensa: " + dinheiroapostado + " moedas. Com seu total sendo: " + dinheiro + ". Parabéns");
                        }
                        else
                        {
                            dinheiro = dinheiro - dinheiroapostado;
                            print("Guerreiro A perdeu! Logo você também, F");
                            print("Força do Guerreiro A: " + atkA + " . Força do Guerreiro B: " + atkB);
                            print("Sobrando apenas " + dinheiro + " moedas");
                        }
                    }
                    else if (guerreiroA == false && guerreiroB == true)
                    {
                        if (atkA < atkB)
                        {
                            dinheiro = dinheiro - dinheiroapostado;
                            dinheiro = dinheiro + (dinheiroapostado * 2);
                            print("Guerreiro B venceu! Você ganhou a aposta!");
                            print("Força do Guerreiro A: " + atkA + " . Força do Guerreiro B: " + atkB);
                            print("Ganhando assim como recompensa: " + (dinheiroapostado * 2) + " moedas. Com seu total sendo: " + ((dinheiroapostado * 2) + (dinheiro - (dinheiroapostado * 2))) + ". Parabéns");
                        }
                        else
                        {
                            dinheiro = dinheiro - dinheiroapostado;
                            print("Guerreiro B perdeu! Logo você também, F");
                            print("Força do Guerreiro A: " + atkA + " . Força do Guerreiro B: " + atkB);
                            print("Sobrando apenas " + dinheiro + " moedas");
                        }
                    }
                    else if (guerreiroA == guerreiroB)
                    {
                        dinheiro = dinheiro + (dinheiroapostado * 100000);
                        print("WOW, deu empate! Que bizarro");
                        print("E agora você está RICO!");
                        print("Com seu saldo sendo" + dinheiro + " moedas");
                    }
                }
            }
            else
            {
                print("Você tem apenas " + dinheiro + " moedas, para de tentar apostar algo impossível");
            }
        }
    }
}
