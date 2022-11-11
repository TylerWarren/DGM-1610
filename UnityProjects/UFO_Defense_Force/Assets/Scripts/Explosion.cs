using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioSource explosionSource;

    void OnCollisionsEnter(Collision collision)

    {
        if(collision.gameObject.tag == "Explosion")
        explosionSource.Play ();
    }
}
