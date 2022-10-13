using UnityEngine;
using UnityEngine.Ui;

[CreateAssetMenu]
public class Indata : ScriptableObject
{
    public int value;

    public void UpdateValue(int number)
    {
        value += number;
    }
}
