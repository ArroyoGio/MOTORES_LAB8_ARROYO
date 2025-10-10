using UnityEngine;

public class PlayerColorShapeConstroller : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        ColorObject.OnChangeColor += ChangeColor;
        ShapeObject.OnChangeShape += ChangeShape;
    }

    private void OnDisable()
    {
        ColorObject.OnChangeColor -= ChangeColor;
        ShapeObject.OnChangeShape -= ChangeShape;
    }

    private void ChangeColor(Color newColor)
    {
        spriteRenderer.color = newColor;
    }

    private void ChangeShape(Sprite newShape)
    {
        spriteRenderer.sprite = newShape;
    }
}
