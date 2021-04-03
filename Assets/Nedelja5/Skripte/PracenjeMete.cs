using UnityEngine;

public class PracenjeMete : MonoBehaviour
{
    public Transform meta;

    private Vector3 startniPomeraj;

    private void Start()
    {
        startniPomeraj = transform.position - meta.position;
    }

    private void Update()
    {
        transform.position = meta.position + startniPomeraj;
    }
}
