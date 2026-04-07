using UnityEngine;

public class While03 : MonoBehaviour
{
    [SerializeField] int quantidade;
    [SerializeField] GameObject Square;
    

    void Start()
    {
        int i = 0;
        float posX = 0;

        while (i < quantidade)
        {
            i++;
            print(i);

            GameObject Squarecopy = Instantiate(Square);
            Squarecopy.transform.position = new Vector2(posX, 0f);
            posX = 1.0f;

        }
        print("FIM");
    }

}
