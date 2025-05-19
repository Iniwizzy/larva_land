using UnityEngine;
using UnityEngine.UI;

public class BallControllers : MonoBehaviour
{
    public int force;
    Rigidbody2D rigid;

    int scoreP1;
    int scoreP2;

    Text scoreUIP1;
    Text scoreUIP2;

    GameObject panelSelesai;
    Text txPemenang;

    AudioSource audioSource;
    public AudioClip hitSound;

    //  Use this for initialization
    void Start()
    {
            rigid = GetComponent<Rigidbody2D>();
            Vector2 arah = new Vector2(2, 0).normalized;
            rigid.AddForce(arah * force);

            scoreP1 = 0;
            scoreP2 = 0;

            scoreUIP1 = GameObject.Find("Score1").GetComponent<Text>();
            scoreUIP2 = GameObject.Find("Score2").GetComponent<Text>();

            panelSelesai = GameObject.Find("PanelSelesai");
            panelSelesai.SetActive(false);

            audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        audioSource.PlayOneShot(hitSound);
        if (coll.gameObject.name == "TepiKanan")
        {
            scoreP1 += 1;
            TampilkanScore();
            if (scoreP1 == 10)
            {
                panelSelesai.SetActive(true);
                txPemenang = GameObject.Find("Pemenang").GetComponent<Text> ();
                txPemenang.text = "Player Kuning Pemenang!";
                Destroy(gameObject);
                return;
            }
            ResetBall();
            Vector2 arah = new Vector2(2, 0).normalized;
            rigid.AddForce(arah * force);
        }
        if (coll.gameObject.name == "TepiKiri")
        {
            scoreP2 += 1;
            TampilkanScore();
            if (scoreP2 == 10)
            {
                panelSelesai.SetActive(true);
                txPemenang = GameObject.Find("Pemenang").GetComponent<Text> ();
                txPemenang.text = "Player Merah Pemenang!";
                Destroy(gameObject);
                return;
            }
            ResetBall();
            Vector2 arah = new Vector2(-2, 0).normalized;
            rigid.AddForce(arah * force);
        }
        if (coll.gameObject.name == "kuning" || coll.gameObject.name ==
        "merah")
        {
        float sudut = (transform.position.y - coll.transform.position.y) * 5f;
        Vector2 arah = new Vector2(rigid.linearVelocity.x, sudut).normalized;
        rigid.linearVelocity = new Vector2(0, 0);
        rigid.AddForce(arah * force * 2);
        }
    }
    void ResetBall()
    {
        transform.localPosition = new Vector2(0, 0);
        rigid.linearVelocity = new Vector2(0, 0);
    }
    void TampilkanScore()
    {
        Debug.Log("Score P1: " + scoreP1 + " Score P2: " + scoreP2);
        scoreUIP1.text = scoreP1 + "";
        scoreUIP2.text = scoreP2 + "";
    }
}
