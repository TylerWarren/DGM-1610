using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour
{
    void Update()
    {
        Time.timeScale = 0; // Freeze Time
    }
}
