using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioClip explosionSource;
    private AudioSource explosion;

    void Start()
    {
        explosionSource = GetComponent<AudioSource>();
    }

    
    void OnCollisionEnter (Collision collision)

    {
        if(collision.gameobject.tag == "Target")

        {
            explosion.PlayOneShot(explosionSource, 1.0f);
        }
    }
}
