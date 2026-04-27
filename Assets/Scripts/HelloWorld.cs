using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    void Start()
    {
        int x;
        int y;
        x = 1;
        y = 2;
        Debug.Log(x + y);

        long a = 123456789012345;
        long b = 2345678901;
        Debug.Log(a * b);

        float c = 1234567890123456;
        float d = 1234567890000000;
        Debug.Log((c == d).ToString());

        bool e = (c == d);
        Debug.Log(e);

        string s = "abcde";
        string t = "fghij";
        Debug.Log(s + t);
    }
}