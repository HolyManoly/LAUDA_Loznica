using UnityEngine;

public class PomerajIgracaVelocity : MonoBehaviour
{
    public float brzina;

    Vector3 deltaPomeraj;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        deltaPomeraj = new Vector3(x, 0f, y);
    }

    void FixedUpdate()
    {
        Vector3 ciljnaBrzina = deltaPomeraj * brzina * Time.fixedDeltaTime;
        GetComponent<Rigidbody>().velocity = ciljnaBrzina;
    }
}
