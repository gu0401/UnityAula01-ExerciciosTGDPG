using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    public int idade;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (idade <= 18)
        {
            print("Você é menor de idade!");
        }
        else
        {
            print("Você é maior de idade!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
