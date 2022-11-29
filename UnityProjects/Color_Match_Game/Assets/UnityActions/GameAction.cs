using UnityEngine;
using UnityEngine.Events;

public class GameAction : ScriptableObjects
{
    public UnityAction raise;

    public void RaiseAction()
    {
        raise?.Invoke();
    }
}
