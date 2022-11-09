using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    private int PowerNum;


    // Start is called before the first frame update
    void Start()
    {
        
        PowerNum = 0;
        MyscoreText.text = "Power : " + PowerNum;

    }


    private void OnTriggerEnter(Collider Pickup)
    {

        if (Pickup.tag == "MyPickup")
        {

            PowerNum += 1;
            Destroy(Pickup.gameObject);
            MyscoreText.text = "Power" + PowerNum;

        }

    }
    
}
