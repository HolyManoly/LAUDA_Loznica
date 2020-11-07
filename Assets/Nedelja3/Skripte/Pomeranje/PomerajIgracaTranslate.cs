using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PomerajIgracaTranslate : MonoBehaviour
{
    [SerializeField]
    private float speed;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 deltaVector = new Vector3(x, 0f, y);
        transform.Translate(deltaVector * speed * Time.deltaTime);
    }
}
