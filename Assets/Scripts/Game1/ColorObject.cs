using UnityEngine;
using System;

public class ColorObject : MonoBehaviour
{
    public static event Action<Color> OnChangeColor;

    [SerializeField] private ColorShapeData colorData;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (colorData != null)
        {
            spriteRenderer.color = colorData.color;
        }
        else
        {
            Debug.LogWarning($"{name} no tiene ColorShapeData asignado.");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && colorData != null)
        {
            OnChangeColor?.Invoke(colorData.color);
            Debug.Log($"Color cambiado a {colorData.color} por {name}");
        }
    }
}
