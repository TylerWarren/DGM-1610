using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioClip explosion;
    private AudioSource explosionSource;

    void Start()
    {
        explosionSource = GetComponent<AudioSource>();
    }
    
    public void OnCollisionsEnter(Collision collision)

    {
        if(collision.gameObject.tag == "Explosion")
    }

    void Update()

    {
        explosionSource.PlayOneShot(explosion, 1.0f);
    }
}
