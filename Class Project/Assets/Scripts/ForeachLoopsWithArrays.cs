using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopsWithArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] Avengers = {"IronMan", "Thor", "Hulk", "Captain America", "Hawkeye", "Black Widow"};
        foreach (string i in Avengers)
        {
            Console.WriteLine(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
