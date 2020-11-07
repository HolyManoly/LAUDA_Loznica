using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPrint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print( gameObject.name + " je pokrenuo OnTriggerEnter, objekat koji je uleteo : " + other.name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print( gameObject.name + " je pokrenuo OnCollisionEnter, objekat koji se sudario : " + collision.collider.name);
    }
}
