using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    public int vida = 100;
    public int dano = 25;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(vida - dano);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
