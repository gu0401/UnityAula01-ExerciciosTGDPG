using UnityEngine;

public class While02 : MonoBehaviour
{
    int count = 0;
    void Start()
    {



    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            while (true)
            {
                count++;
                int n = Random.Range(1, 100);

                if (n % 2 == 0)
                {
                    print("Foram necessárias " + count + " veze(s) para encontrar um número par");
                    print(n);
                    break;
                }
            }
        }
    }
}
