using Unity.VisualScripting;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    void Start()
    {
<<<<<<< HEAD
        int a = 3;
        int r = 2;
        int[] n = new int[10];
        
        for (int i = 0; i < 10; i++)
        {
            n[i] = a;
            a *= r;
            Debug.Log(n[i]);
=======
        int a = 2;
        int b = 2;
        int count = 0;
        while (a <= 1000)
        {
            a *= b;
            count++;
        }
        Debug.Log(count + "번 곱하면 1000을 넘습니다.");
       
        for (int i = 1; i < 10; i += 2)
        {
            string stars = "";
            for (int j = 0; j < i;  j++)
            {
                stars += "*";
            }
            Debug.Log(stars);
>>>>>>> ad4052bffbfe942b88e620962feb9076604f1e94
        }
       



<<<<<<< HEAD
    }  
=======
        for (int c = 2; c < 10; c++)
        {
            for (int d = 1; d < 10; d++)
            {
                int answer = c * d;
                Debug.Log(c + "*" + d + "=" + answer);
            }
        }

    }
>>>>>>> ad4052bffbfe942b88e620962feb9076604f1e94
 }