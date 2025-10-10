using System;
using UnityEngine;

public class ColorObject : MonoBehaviour
{
    public ColorShapeData colorData;
    private SpriteRenderer spriteRenderer;

    public static event Action<Color> OnChangeColor;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (colorData != null)
            spriteRenderer.color = colorData.color;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && colorData != null)
        {
            OnChangeColor?.Invoke(colorData.color);
        }
    }
}
