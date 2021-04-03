using UnityEngine;

public class PomerajIgracaTranslate : MonoBehaviour
{
    public float brzina;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 deltaPomeraj = new Vector3(x, 0f, y);
        transform.Translate(deltaPomeraj * brzina * Time.deltaTime);
    }
}
