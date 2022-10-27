using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDelate : MonoBehaviour
{
    void OnCollisionEnter(Collision collider)
    {
        if(collider.gameObject.tag == "Pickup")

        {
            Destroy(collider.gameObject);
        }
    }
} 

