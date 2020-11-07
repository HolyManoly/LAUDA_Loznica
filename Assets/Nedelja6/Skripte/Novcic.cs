using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Novcic : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        //Invoke("DestroyMe", audioSource.clip.length);
    }

    //private void DestroyMe()
    //{
    //    Destroy(gameObject);
    //}
}
