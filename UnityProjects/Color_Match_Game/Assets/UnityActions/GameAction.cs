using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class GameAction : ScriptableObjects
{
    public UnityAction raise;

    public void RaiseAction()
    {
        raise?.Invoke();
    }
}
