using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    public int n1;
    public int n2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (n1>n2)
        {
            print(n1 + " n1 é o maior!");
        }
        else
        {
            print(" n2 é o maior!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
