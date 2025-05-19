using UnityEngine;
using UnityEngine.UI; // Untuk akses ke Text UI

public class DeteksiSampah : MonoBehaviour
{
    public static int score;
    public string nameTag;

    public AudioClip audioBenar;
    public AudioClip audioSalah;

    private AudioSource mediaPlayerBenar;
    private AudioSource mediaPlayerSalah;

    public Text textScore;

    void Start()
    {
        // Tambahkan dua AudioSource dan atur klipnya
        mediaPlayerBenar = gameObject.AddComponent<AudioSource>();
        mediaPlayerBenar.clip = audioBenar;

        mediaPlayerSalah = gameObject.AddComponent<AudioSource>();
        mediaPlayerSalah.clip = audioSalah;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(nameTag))
        {
            score += 25;
            textScore.text = score.ToString();
            mediaPlayerBenar.Play();
        }
        else
        {
            score -= 5;
            textScore.text = score.ToString();
            mediaPlayerSalah.Play();
        }

        Destroy(collision.gameObject);
    }
}
