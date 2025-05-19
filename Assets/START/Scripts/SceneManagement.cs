using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public string playIntro = "Intro"; // Ganti dengan nama scene tujuan
    public string playBack = "Start"; // Ganti dengan nama scene tujuan
    public string playNext = "MainMenu"; // Ganti dengan nama scene tujuan
    public string playQuit = "Quit"; // Ganti dengan nama scene tujuan
    public string playCredit = "Credit"; // Ganti dengan nama scene tujuan


    public string playGame1 = "Gameplay1"; // Ganti dengan nama scene tujuan
    public string playGame2 = "Main"; // Ganti dengan nama scene tujuan
    public string playGame3 = "Gameplay3"; // Ganti dengan nama scene tujuan

    // 🏠 Fungsi untuk tombol "home"
    public void intro(){
        SceneManager.LoadScene(playIntro);
    }

    public void back(){
        SceneManager.LoadScene(playBack);
    }

    public void next(){
        SceneManager.LoadScene(playNext);
    }

    public void quit(){
        SceneManager.LoadScene(playQuit);
    }

    public void credit(){
        SceneManager.LoadScene(playCredit);
    }
    
    public void game1()
    {
        SceneManager.LoadScene(playGame1);
    }

    public void game2()
    {
        SceneManager.LoadScene(playGame2);
    }

    public void game3()
    {
        SceneManager.LoadScene(playGame3);
    }

    void Update()
    {
        // Deteksi tombol Enter ditekan
        if (Input.GetKeyDown(KeyCode.Return)) // atau KeyCode.KeypadEnter
        {
            SceneManager.LoadScene("Start"); // Ganti dengan nama scene menu utama kamu
        }
    }
}
