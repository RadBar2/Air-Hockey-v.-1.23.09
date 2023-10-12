using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI scoreTxt;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pin"))
        {
            scoreTxt.text = (++score).ToString();
            audioSource.Play();
        }
    }
}
