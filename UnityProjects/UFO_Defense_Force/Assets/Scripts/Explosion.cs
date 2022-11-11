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
    
    void OnTriggerEnter(Collider other)

    {
        explosionSource.PlayOneShot(explosion, 1.0f);
    }

    void Update()

    {
        
    }
}
