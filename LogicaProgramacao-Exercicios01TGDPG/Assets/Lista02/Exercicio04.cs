using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    public int n1;
    public int n2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (n1==n2)
        {
            print("O n1 é igual a n2!");
        }
        else
        {
            print("O n1 é diferente de n2!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
