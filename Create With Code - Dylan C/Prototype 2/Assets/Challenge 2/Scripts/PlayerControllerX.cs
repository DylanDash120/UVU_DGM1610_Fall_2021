using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1.0f; //player wait time to fire dog again
    private float nextFire = 0.0f; // time after player can fire again

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;//reset nextFire to current time + fireRate

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
