using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Separandotiposdefrutas : MonoBehaviour
{

    /*
Exercício: Separando Tipos de Frutas
Objetivo
Praticar o uso de array, foreach e substring em C#.
Enunciado
Crie um programa que trabalhe com uma lista de frutas. Cada fruta será representada
por uma string no formato:
"Nome-Tipo"
Exemplos:
"Banana-Doce"
"Limao-Acido"
"Morango-Doce"
"Maracuja-Acido"
O que o programa deve fazer
1. Crie um array com pelo menos 4 frutas.
2. Use um foreach para percorrer todas as frutas do array.
3. Para cada fruta:
o Use Substring para separar:
▪ o nome da fruta
▪ o tipo (Doce ou Ácido)
4. Exiba na tela no seguinte formato:
Fruta: Banana | Tipo: Doce
Fruta: Limao | Tipo: Acido
Requisitos obrigatórios
• Uso de array X
• Uso de foreach X
• Uso de Substring
• Uso de variáveis auxiliares
Desafio extra
• Mostrar apenas as frutas doces
• Contar quantas frutas são ácidas
    */

    [SerializeField] private string[] pokemontipos = { "Kommoo-Dragão", "Houndoom-Fogo", "Rayquaza-Voador", "Rootom-Fantasma"};

    void Start()
    {

        //Verificar se tem pelo menos 4 pokemon preenchidas
        int contador = 0;

        foreach (string pokemon in pokemontipos)
        {
            if (pokemon != "")
            {
                contador++;
            }
        }

        if (contador < 4)
        {
            print("Digite apenas 4 pokemon no array.");
            return;
        }
        else
        {
            //Percorrer cada pokemon
            foreach (string pokemon in pokemontipos)
            {
                if (pokemon == "")
                    continue;

                string nomepokemon = "";
                string tipo = "";
                bool traco = false;

                //Percorrer letra por letra
                for (int i = 0; i < pokemon.Length; i++)
                {
                    string letra = pokemon.Substring(i, 1);

                    if (letra == "-")
                    {
                        traco = true;
                    }
                    else
                    {
                        if (traco)
                        {
                            tipo += letra;
                        }
                        else
                        {
                            nomepokemon += letra;
                        }
                    }
                }

                //Exibir resultado
                print("Pokemon: " + nomepokemon + " | Tipo: " + tipo);
            }
        }
    }
}
