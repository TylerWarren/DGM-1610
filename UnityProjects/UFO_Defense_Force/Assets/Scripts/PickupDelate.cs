using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDelate : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision) 
    {
        if (collision.tag == "Player")
        {
            Destroy (gameObject);
        }
    }
} 

