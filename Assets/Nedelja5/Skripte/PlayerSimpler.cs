using System.Collections.Generic;
using UnityEngine;

public class PlayerSimpler : MonoBehaviour
{
    public float moveForce = 10;
    public float jumpForce = 4;

    private Animator animator;
    private Rigidbody rigidBody;

    public Transform modelTransform;

    private bool jumpInput;

    private float xInput;

    private float yInput;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        if (!jumpInput && Input.GetKeyDown(KeyCode.Space))
        {
            jumpInput = true;
        }
    }

    private void FixedUpdate()
    {
        Transform camera = Camera.main.transform;

        // Izracunaj input u odnosu na kameru
        Vector3 direction = camera.forward * yInput + camera.right * xInput;
        direction.y = 0;
        direction.Normalize();

        // Ako igrac hoce da se krece
        if (direction.magnitude > 0)
        {
            modelTransform.rotation = Quaternion.LookRotation(direction);
            rigidBody.AddForce(direction * moveForce);
            animator.SetBool("Moving", true);
        }
        else
        {
            animator.SetBool("Moving", false);
        }

        if (jumpInput)
        {
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpInput = false;
            animator.SetTrigger("Jump");
        }
    }

}
