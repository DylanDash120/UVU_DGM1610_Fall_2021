using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void FixedUpdate()
    {
        DeBug.Log("FixedUpdate time :" + Time.deltaTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DeBug.Log("Update time :" + Time.deltaTime);
    }
}
