using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0; // Freeze Time
        Button btn = yourButton.GetComponent<StartButton>();
		btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Time.timeScale = 1;
    }
}
