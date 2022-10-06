using UnityEngine;
using System.Collections;

[System.Serializable]
public class DataClass {
    public int myInt;
    public float myFloat;

}

public class DemoScript : MonoBehaviour {

    public Light myLight;
    public DetaClass myClass;

    void Awake () {
        int myVar = AddTwo(9,2);
        Debug.Log(myVar);

    }

    void Update () {
        if (Input.GetKeyDown) ("space")) {
            MyFunction ();

        }

    }

    void MyFunction () {
        myLight.enabled = !myLight.enabled;
    }