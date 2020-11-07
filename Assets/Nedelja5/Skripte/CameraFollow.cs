using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    private Vector3 startOffset;

    private void Start()
    {
        startOffset = transform.position - target.position;
    }

    private void Update()
    {
        transform.position = target.position + startOffset;
    }
}
