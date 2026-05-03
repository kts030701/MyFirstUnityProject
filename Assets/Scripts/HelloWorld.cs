using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class HelloWorld : MonoBehaviour
{
    void Start()
    {
        Character charles = new Character("Charles", 10);

        charles.Hit(5);
        charles.Heal(3);

        Debug.Log(charles.IsAlive());

        charles.Hit(10);

        Debug.Log(charles.IsAlive());
    }

 }