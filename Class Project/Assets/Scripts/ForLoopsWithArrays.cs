using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsWithArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] Avengers = {"IronMan", "Thor", "Hulk", "Captain America", "Hawkeye", "Black Widow"};
        for (int i = 0; i < Avengers.Length; i++)
        {
            Console.WriteLine(Avengers[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
