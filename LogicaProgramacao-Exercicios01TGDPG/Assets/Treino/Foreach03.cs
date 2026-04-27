using UnityEngine;

public class Foreach03 : MonoBehaviour
{
    [SerializeField] string[] cores = { "Azul", "Verde", "Amarelo" };
    void Start()
    {
        foreach(string cor in cores)
        {
            print(cor);
        }
    }
}
