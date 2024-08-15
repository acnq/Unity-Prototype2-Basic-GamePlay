using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float coolDown = 0; // used to avoid user to press "Space" constantly.

    // Update is called once per frame
    void Update()
    {
        if (coolDown > 0)
        {
            coolDown -= Time.deltaTime;
        }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && coolDown <= 0)
        {
            coolDown = 0.5f;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }       
    }
}
