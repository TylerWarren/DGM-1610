using UnityEngine;

public class Vector3Data : ScriptableObject
{
void Reach()
    {
        transform.position += Vector3.back * Time.deltaTime;
    }
}
