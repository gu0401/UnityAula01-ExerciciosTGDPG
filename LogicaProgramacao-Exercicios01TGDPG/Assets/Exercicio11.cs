using UnityEngine;

public class Exercicio11 : MonoBehaviour
{
    public float velocidadeInicial;
    public float aceleracao;
    public float tempo;
    public float velocidadeFinal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(velocidadeFinal = velocidadeInicial + aceleracao * tempo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
