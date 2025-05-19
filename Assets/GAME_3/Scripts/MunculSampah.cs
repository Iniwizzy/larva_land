using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculSampah : MonoBehaviour
{   
    public float jeda = 0.8f;
    private float timer = 0f;

    public GameObject[] obyekSampah;

        void Start()
    {
        for (int i = 0; i < obyekSampah.Length; i++)
        {
            if (obyekSampah[i] == null)
            {
                // Debug.LogWarning($"obyekSampah[{i}] is null di Start(). Harap isi dengan prefab yang valid.");
            }
        }
    }

        void Update()
    {
        timer += Time.deltaTime;

        if (timer >= jeda && obyekSampah.Length > 0)
        {
            int random = Random.Range(0, obyekSampah.Length);

            if (obyekSampah[random] != null)
            {
                Instantiate(obyekSampah[random], transform.position, Quaternion.identity);
            }
            else
            {
                // Debug.LogWarning($"obyekSampah[{random}] is null! Cek prefab di Inspector.");
            }

            timer = 0f;
        }
    }

}
