using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class HelloWorld : MonoBehaviour
{
    void Start()
    {
        List<int> a = new List<int>();
        a.Add(22);
        a.Add(3);
        a.Add(14);
        a.Add(8);
        a.Add(5);
        a.Add(12);
        a.Add(3);
        a.Add(19);
        a.Add(2);
        a.Add(1);

        for (int i = 0; i < a.Count-1; i++)
        {
            for (int j=i+1; j < a.Count; j++)
            {
                if (a[i] > a[j])
                {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                }
            }
        }
        foreach (int i in a)
        {
            Debug.Log(i);
        }
    }

 }