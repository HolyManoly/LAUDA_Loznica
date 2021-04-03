using System.Collections.Generic;
using UnityEngine;

public class IgracNapredno : MonoBehaviour
{
    public float silaPomeranja = 10;
    public float silaSkakanja = 4;

    private Animator animator;
    private Rigidbody rigidBody;

    private bool naZemlji;
    private bool bioNaZemlji;

    public Transform modelTransform;

    private bool skokInput;

    private float xInput;

    private float yInput;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        naZemlji = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        naZemlji = false;
    }

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        if (!skokInput && Input.GetKeyDown(KeyCode.Space))
        {
            skokInput = true; 
        }
    }

    private void FixedUpdate()
    {
        animator.SetBool("NaZemlji", naZemlji);

        Transform camera = Camera.main.transform;

        // Izracunaj input u odnosu na kameru
        Vector3 pravac = camera.forward * yInput + camera.right * xInput;
        pravac.y = 0;
        pravac.Normalize();

        // Ako igrac hoce da se krece
        if (pravac.magnitude > 0)
        {
            modelTransform.rotation = Quaternion.LookRotation(pravac);
            rigidBody.AddForce(pravac * silaPomeranja);
        }

        animator.SetFloat("Brzina", pravac.magnitude);

        if (skokInput)
        {
            rigidBody.AddForce(Vector3.up * silaSkakanja, ForceMode.Impulse);
            skokInput = false;
            animator.SetTrigger("Skok");
        }

        if (!bioNaZemlji & naZemlji)
        {
            animator.SetTrigger("Doskok");
        }

        if (!naZemlji && bioNaZemlji)
        {
            animator.SetTrigger("Kretanje");
        }

        bioNaZemlji = naZemlji;
    }

}
