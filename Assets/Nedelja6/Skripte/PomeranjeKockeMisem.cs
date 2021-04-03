using UnityEngine;
using UnityEngine.SceneManagement;

public class PomeranjeKockeMisem : MonoBehaviour
{
    private Vector3 targetPosition;

    private int brojPoena;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            SetTargetPosition();
        }
    }

    private void SetTargetPosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 5, Color.red, .2f);

        bool pogodioSamNesto = Physics.Raycast(ray, out hit);
        if (pogodioSamNesto)
        {
            targetPosition = hit.point;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print("On trigger enter pomeranje kocke");
        brojPoena++;

        if (brojPoena == 5)
        {
            SceneManager.LoadScene(0);
        }
    }
}
