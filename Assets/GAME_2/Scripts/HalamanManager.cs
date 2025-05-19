using UnityEngine;
using UnityEngine.SceneManagement;
public class HalamanManager : MonoBehaviour
{
    public bool isEscapeToExit;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isEscapeToExit)
            {
                Application.Quit();
            }
            else
            {
                PlayAgain();
            }
        }
    }
    public void Play()
    {
        SceneManager.LoadScene("Main");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Menu");
    }
}
