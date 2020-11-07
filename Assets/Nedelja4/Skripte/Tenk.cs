using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tenk : MonoBehaviour
{
    public Transform vrh;

    public float brzinaRotacije;

    public float brzinaKretanja;

    public float xDometKretanja;

    public GameObject metakPrefab;

    public Transform mestoIspaljivanjaMetka;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 deltaPomeraj = new Vector3(x, 0f, y);

        transform.Translate(brzinaKretanja * deltaPomeraj * Time.deltaTime);

        Vector3 trenutnaPozicija = transform.position;

        if (trenutnaPozicija.x < -xDometKretanja)
        {
            trenutnaPozicija.x = -xDometKretanja;
        }
        if (trenutnaPozicija.x > xDometKretanja)
        {
            trenutnaPozicija.x = xDometKretanja;
        }

        transform.position = trenutnaPozicija;

        if (Input.GetKey(KeyCode.Q))
        {
            vrh.Rotate(0f, -brzinaRotacije * Time.deltaTime, 0f);
        }
        
        if (Input.GetKey(KeyCode.E))
        {
            vrh.Rotate(0f, brzinaRotacije * Time.deltaTime, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(metakPrefab, mestoIspaljivanjaMetka.position, mestoIspaljivanjaMetka.rotation);
        }
    }
}
