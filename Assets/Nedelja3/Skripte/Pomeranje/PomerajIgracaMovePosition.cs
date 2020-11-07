using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PomerajIgracaMovePosition : MonoBehaviour
{
    [SerializeField]
    private float speed;

    Vector3 deltaVector;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        deltaVector = new Vector3(x, 0f, y);
    }

    void FixedUpdate()
    {
        Vector3 targetPosition = transform.position + (deltaVector * speed * Time.fixedDeltaTime);
        GetComponent<Rigidbody>().MovePosition(targetPosition);
    }
}
