using UnityEngine;

public class Exercicio03 : MonoBehaviour
{
    public int n1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (n1 % 2 ==0)
        {
            print(n1 + " é par!");
        }
        else
        {
            print(n1 + " é impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
