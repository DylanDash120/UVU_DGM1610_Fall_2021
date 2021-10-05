using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalsConditionals : MonoBehaviour
{
    private int x = 10;

    private int y = 20;
    
    if (x<y)
    {
        Console.WriteLine("y is greater than x");
    }
    else if (x>y)
    {
        Console.WriteLine("x is greater than y");
    }
    else
    {
        Console.WriteLine("x is equal to y");
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
