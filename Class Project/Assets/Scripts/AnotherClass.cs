using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples;

    public int bananas;

    private int stapler;

    private int sellotapes;

    public void FruitMachine(int a, int b)
    {
        int answer;
        amswer = a + b;
        DeBug.Log("Fruit total: " + answer);
    }

    private void OfficeSort(int a, int b);
    {
        int answer;
        answer = a + b;
        DeBug.Log("Office Supplies total: " + answer);
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
