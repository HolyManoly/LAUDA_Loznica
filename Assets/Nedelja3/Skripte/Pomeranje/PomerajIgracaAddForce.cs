using UnityEngine;

public class PomerajIgracaAddForce : MonoBehaviour
{
    Vector3 deltaPomeraj;

    public float pojacavacSilePomeranja;

    public GameObject zidZaUnistiti;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        deltaPomeraj = new Vector3(x, 0f, y);
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(deltaPomeraj * pojacavacSilePomeranja);
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
