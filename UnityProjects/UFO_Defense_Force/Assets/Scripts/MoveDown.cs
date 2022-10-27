using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 2;
    void Update()
    {
        // Move GameObject Down.
        transform.Translate(Vector3.Down * speed * Time.deltaTime);
    }
}
