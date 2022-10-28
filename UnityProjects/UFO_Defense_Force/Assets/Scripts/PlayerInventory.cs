using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int Power { get; private set; }

    public void PowerCollected()

    {
        Power++;
    }
}
