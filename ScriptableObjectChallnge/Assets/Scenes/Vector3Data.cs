using UnityEngine;

public class Vector3Data : ScriptableObject
{
void Reach()
    {
       position += Vector3.back * Time.deltaTime;
    }
}
