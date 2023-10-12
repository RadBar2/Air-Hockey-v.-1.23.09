using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer), typeof(Rigidbody2D))]
public class Pin : MonoBehaviour
{
    AudioSource audioSource;
    SpriteRenderer renderer;
    Rigidbody2D rb;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        renderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!renderer.isVisible)
        {
            rb.velocity = Vector3.zero;
            transform.position = Vector3.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(audioSource != null)
        {
            var volume = collision.relativeVelocity.magnitude / 50;
            audioSource.volume = volume;
            audioSource.Play();
        }
    }
}
