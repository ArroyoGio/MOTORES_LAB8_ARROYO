using System;
using UnityEngine;

public class ShapeObject : MonoBehaviour
{
    public ColorShapeData shapeData;
    private SpriteRenderer spriteRenderer;

    public static event Action<Sprite> OnChangeShape;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (shapeData != null)
            spriteRenderer.sprite = shapeData.sprite;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && shapeData != null)
        {
            OnChangeShape?.Invoke(shapeData.sprite);
        }
    }
}
