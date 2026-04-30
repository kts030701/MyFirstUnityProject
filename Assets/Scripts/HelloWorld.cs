using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class HelloWorld : MonoBehaviour
{
    void Start()
    {
        Dictionary <string, string> 한영사전 = new Dictionary<string, string> ();
        한영사전.Add("쥐", "mouse");
        한영사전.Add("잔", "cup");
        한영사전.Add("손", "hand");
        한영사전.Add("물", "water");
        한영사전.Add("발", "foot");

        Dictionary<string, string> 영한사전 = new Dictionary<string, string>();

        foreach (string key in 한영사전.Keys)
        {
            영한사전.Add(한영사전[key], key);
        }

        foreach (string key in 영한사전.Keys)
        {
            Debug.Log(key + " : " + 영한사전[key]);
        }
    }

 }