using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    private int order = 3;
    switch(order)
    {
        case 1:
        Console.WriteLine("Burger");
        yield break;
        case 2:
        Console.WriteLine("Burger and Fries");
        yield break;
        case 3:
        Console.WriteLine("CheeseBurger");
        yield break;
        case 4:
        Console.WriteLine("Burger and a Shake");
        yield break;
        case 5:
        Console.WriteLine("Fries and a Shake");
        yield break;
        default:
        Console.WriteLine("Water");
        yield break;

    }
}
