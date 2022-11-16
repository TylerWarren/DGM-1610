using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    private void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRenderColor(Color color)
    {
        rendererObj.color = color;
    }
}
