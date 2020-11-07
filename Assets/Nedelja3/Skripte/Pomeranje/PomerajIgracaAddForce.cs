using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PomerajIgracaAddForce : MonoBehaviour
{
    Vector3 deltaVector;

    public float forceMultiplier;

    public GameObject zidZaUnistiti;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        deltaVector = new Vector3(x, 0f, y);
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(deltaVector * forceMultiplier);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print( gameObject.name + " je pokrenuo OnCollisionEnter, objekat koji se sudario : " + collision.collider.name);

        if (collision.gameObject == zidZaUnistiti)
        {
            Destroy(zidZaUnistiti);
        }
    }    
}
