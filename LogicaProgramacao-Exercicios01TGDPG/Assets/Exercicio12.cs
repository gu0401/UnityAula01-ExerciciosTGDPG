using UnityEngine;

public class Exercicio12 : MonoBehaviour
{
    public int pontosBase;
    public int inimigosDerrotados;
    public int bonus;
    public int pontuacaoFinal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(pontuacaoFinal = (pontosBase * inimigosDerrotados) + bonus);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
