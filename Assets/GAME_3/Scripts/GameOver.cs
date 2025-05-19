using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    float timer = 0;
    //  Update is called once per frame
    void Update() {
        timer += Time.deltaTime;
        if (timer > 2) {
            Data.score = 0;
            SceneManager.LoadScene("Gameplay3");
        }
    }
}
