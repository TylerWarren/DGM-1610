using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDelate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        {
            PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

            if (playerInventory != null)
            gameObject.SetActive(false);
        }
    }
} 

