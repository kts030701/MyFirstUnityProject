using Unity.VisualScripting;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    void Start()
    {
        int number = -123;
        if (number > 0)
        {
            Debug.Log("양수");
        }
        else if (number < 0)
        {
            Debug.Log("음수");
        }
        else
        {
            Debug.Log(0);
        }

        int year = 2026;
        if (year % 4 == 0) 
        {
             Debug.Log("윤년");
        }
        else
        {
             Debug.Log("평년");
        }
        string cal = "-";
        int num1 = 2;
        int num2 = 7;
        switch (cal)
        {
            case "+":
                Debug.Log(num1 + num2);
                    break;
            case "-":
                Debug.Log(num1 - num2);
                    break;
            case "*":
                Debug.Log(num1 * num2);
                    break;
            case "/":
                Debug.Log(num1 / num2);
                    break;
        }
      
    }  
 }