using Unity.VisualScripting;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    void Start()
    {
        int a = 3;
        int r = 2;
        int[] n = new int[10];
        
        for (int i = 0; i < 10; i++)
        {
            n[i] = a;
            a *= r;
            Debug.Log(n[i]);
        }
       



    }  
 }