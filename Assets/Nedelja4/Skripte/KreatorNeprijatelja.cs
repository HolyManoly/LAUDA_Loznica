using UnityEngine;

public class KreatorNeprijatelja : MonoBehaviour
{
    public GameObject prefabNeprijatelja;

    public float zPozicijaKreiranja;

    public float maksimalnaXPozicijaKreiranja;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(KreirajNeprijatelja), 1f, 1f);
    }

    private void KreirajNeprijatelja()
    {
        Vector3 pozicijaKreiranja = new Vector3();
        pozicijaKreiranja.x = Random.Range(-maksimalnaXPozicijaKreiranja, maksimalnaXPozicijaKreiranja);
        pozicijaKreiranja.z = zPozicijaKreiranja;
        pozicijaKreiranja.y = 0f;

        Instantiate(prefabNeprijatelja, pozicijaKreiranja, Quaternion.Euler(0f, -180f, 0f));
    }
}
