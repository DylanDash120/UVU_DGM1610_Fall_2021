using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    void Awake()
    {
        DeBug.Log("Awake called.");
    }
    // Start is called before the first frame update
    void Start()
    {
        DeBug.Log("Start called.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
