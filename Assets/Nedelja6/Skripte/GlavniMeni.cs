using UnityEngine;
using UnityEngine.SceneManagement;

public class GlavniMeni : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PokreniIgru();
        }
    }

    public void PokreniIgru()
    {
        SceneManager.LoadScene(1);
    }
}
