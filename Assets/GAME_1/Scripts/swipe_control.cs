using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class swipe_control : MonoBehaviour
{
    public GameObject scrollbar;
    public string homeSceneName = "MainMenu"; // Ganti dengan nama scene tujuan

    float scroll_pos = 0;
    float[] pos;
    int posisi = 0;

    void Start () {
        pos = new float[transform.childCount];
    }

    public void next(){
        if (posisi < pos.Length - 1) {
            posisi += 1;
            scroll_pos = pos[posisi];
        }
    }

    public void prev(){
        if (posisi > 0) {
            posisi -= 1;
            scroll_pos = pos[posisi];
        }
    }

    void Update () {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1);

        for (int i = 0; i < pos.Length; i++) {
            pos[i] = distance * i;
        }

        if (Input.GetMouseButton(0)) {
            scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
        } else {
            for (int i = 0; i < pos.Length; i++) {
                if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2)) {
                    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(
                        scrollbar.GetComponent<Scrollbar>().value,
                        pos[i],
                        0.15f
                    );
                    posisi = i;
                }
            }
        }
    }

    // 🔊 Fungsi tombol musik
    public void PlayCurrentInstrumentSound()
    {
        // Cari anak yang aktif saat ini berdasarkan posisi
        if (posisi >= 0 && posisi < transform.childCount)
        {
            Transform currentInstrument = transform.GetChild(posisi);
            AudioSource audio = currentInstrument.GetComponentInChildren<AudioSource>();

            if (audio != null)
            {
                audio.Play();
            }
            else
            {
                Debug.LogWarning("AudioSource tidak ditemukan di " + currentInstrument.name);
            }
        }
    }

    // 🏠 Fungsi tombol home
    public void GoToHome()
    {
        SceneManager.LoadScene(homeSceneName);
    }
}
