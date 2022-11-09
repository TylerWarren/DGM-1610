using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
   public ScoreManager scoreManager; // Store referance to score manager

   public int scoreToGive;

   void Start()
   {
      scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager gameobject and reference ScoreManager script component

   }
   void OnTriggerEnter(Collider other) // Once the Trigger had been entered record collision in the argument variable "other"
   {
      scoreManager.IncreaseScore(scoreToGive); // Increase the Score 
      Destroy(GameObject); // Destroy this gameobject
      Destroy(other.gameObject); // Destroy the other gameobject it hits
   }

}

