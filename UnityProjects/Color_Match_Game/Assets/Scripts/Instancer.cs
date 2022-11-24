using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;

    public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstance(Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3List[0].value, Quaternion.identity);
    }
}
