using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class IntData : ScriptableObject

{
    public UnityEvent disableEvent;

    public int value;

    public void SetValue(int num)
    {
        value = num;
    }

    public void UpdateValue(int num)
    {
        value += num;
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}
