using UnityEngine;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    private ID otherID;

    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if(tempObj != null) otherID = tempObj.idObj;

        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            Debug.Log("Matched");
        }
    }
}
