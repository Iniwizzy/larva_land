using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitManager : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit(); // Tidak bekerja di Editor
    }

    public void CancelQuit()
    {
        SceneManager.LoadScene("Start"); // Ganti sesuai nama scene menu utama kamu
    }
}
