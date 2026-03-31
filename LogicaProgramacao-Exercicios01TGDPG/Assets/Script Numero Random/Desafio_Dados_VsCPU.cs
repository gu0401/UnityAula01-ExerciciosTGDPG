using UnityEngine;

public class Desafio_Dados_VsCPU : MonoBehaviour
{
    [SerializeField] int vidaj;
    [SerializeField] int atkj;
    [SerializeField] int defj;
    [SerializeField] int pontos = 5;

    [SerializeField] int vidac;
    [SerializeField] int atkc;
    [SerializeField] int defc;

    [SerializeField] int dado1;
    [SerializeField] int dado2;


    void Start()
    {
       

    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            dado1 = Random.Range(1, 7);
            dado2 = Random.Range(1, 7);
            if (dado1 % 2 == 0)
            {
                print("Par, então você irá atacar!");
            }
        }
}
}
