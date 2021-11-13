using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] hurdles;

    private Vector3 spawnPos = new Vector3(20, 1, -2);
    private float startDelay = 2.0f;
    private float repeatRate = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnHurdle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnHurdle()
    {
        int hurdleIndex = Random.Range(0, hurdles.Length);
        Instantiate(hurdles[hurdleIndex], spawnPos, hurdles[hurdleIndex].transform.rotation);
    }
}
