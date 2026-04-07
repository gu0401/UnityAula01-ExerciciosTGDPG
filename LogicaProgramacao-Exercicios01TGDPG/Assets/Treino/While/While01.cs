using UnityEngine;

public class While01 : MonoBehaviour
{
    [SerializeField] int b = 100;

    void Start()
    {
        int a = 0;

        while (a < b)
        {
            print(a);
            a++;
        }
    }


}
