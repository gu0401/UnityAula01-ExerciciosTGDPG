using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    public int pontos = 10;
    public int multiplicador = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(pontos * multiplicador);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
