using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float startdelay = 1.0f;
    public float time = 2f;
    public float timee = 0f; 

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timee)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

                timee = Time.time + time;
            }
        }





     
    }
}
