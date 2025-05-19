using UnityEngine;
using UnityEngine.SceneManagement; // untuk ganti scene

public class ScrollCredits : MonoBehaviour
{
    public float scrollSpeed = 2f;

    void Update()
    {
        transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);

        // Deteksi tombol Enter ditekan
        if (Input.GetKeyDown(KeyCode.Return)) // atau KeyCode.KeypadEnter
        {
            SceneManager.LoadScene("Start"); // Ganti dengan nama scene menu utama kamu
        }
    }
}
