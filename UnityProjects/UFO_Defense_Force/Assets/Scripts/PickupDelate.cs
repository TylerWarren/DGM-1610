using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDelate : MonoBehaviour
{
    
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        
        if(gameObject != null)
        {
            Destroy (gameObject);
        }
    }
} 

