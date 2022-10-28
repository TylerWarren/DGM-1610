using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDelate : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collision.tag == "Player")
        {
            Destroy (gameObject);
        }
    }
} 

