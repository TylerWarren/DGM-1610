using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDelate : MonoBehaviour
{
    private void OnCollisionEnter(Collision collider) 
    {
      GameObject.Destroy(gameObject);
    }
} 

