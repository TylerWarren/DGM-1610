using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDelate : MonoBehaviour
{
 void OnCollisionEnter(Collision collision) 

 { if(collision.gameObject.name == "barrierdestroyer1")
     { Destroy(barrier1); 
         }
     } 
 } 

