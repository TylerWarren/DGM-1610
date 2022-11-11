using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioSource explosionScource;

    void Start()
    {
        explosionSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter (Collision collision)

    {
        if(collision.gameobject.tag == "Explosion")

        {
            explosionSource.Play();
        }
    }
}
