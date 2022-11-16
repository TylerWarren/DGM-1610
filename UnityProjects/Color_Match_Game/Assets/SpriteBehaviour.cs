using UnityEngine;

[RequireComponwnt(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    private void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }
}
