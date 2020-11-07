using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PomerajNapred : MonoBehaviour
{
    public float brzina;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * brzina * Time.deltaTime);
    }
}
