using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float ugaoRotacijePoSekundi = 90;

    private float brzinaPomeranjaPoSekundi = 1;

    // Start metoda se poziva jednom, na pocetku : https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html
    void Start()
    {
        // Testiranje kako bi igra radila na slabijem uredjaju
        // Application.targetFrameRate = 2;
    }

    // Update metoda se poziva na svakom frejmu : https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html
    void Update()
    {
        // Teleport kontrole
        // Input.GetKeyDown ce biti tacan samo prilikom spustanja tipke 
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.Translate(0, 0, 1, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            transform.Translate(0, 0, 1, Space.World);
        }

        // Kontinualno kretanje
        // Input.GetKey ce biti tacan za sve vreme dok je tipka pritisnuta
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -ugaoRotacijePoSekundi * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, ugaoRotacijePoSekundi * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, brzinaPomeranjaPoSekundi * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -brzinaPomeranjaPoSekundi * Time.deltaTime);
        }
    }

    // Zadaci : 

    // 1. Dodaj da se na tipku R pozicija igraca Resetuje na x = 2, y = 0, z = 2 

    // 2. Modifikuj skriptu tako da se igrac teleportuje duplo vise na tipke L i G, a rotira duplo sporije na tipke A i D

    // 3. Modifikuj skriptu tako da se, nakon pustanja W i S kontrola igrac lagano zaustavi, kroz nekoliko frejmova

    // 4. Napravi novu skriptu za kameru koja na Z i C okreće kameru oko centra globalnog prostora 

    // 5. Modifikuj skriptu za kretanje igraca tako da, sa novom kamerom, igrac na W i S uvek krece napred i nazad u odnosu na pravac koji kamera pokazuje
}
