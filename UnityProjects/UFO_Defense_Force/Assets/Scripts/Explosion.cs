using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioSource explosionSound;

    void OnCollisionsEnter(Collision collision)

    {
        if(collision.gameObject.tag == "Explosion")
        explosionSound.Play();
    }
}
