using UnityEngine;
using UnityEngine.UI;

public class ColorPanel : MonoBehaviour
{
    [SerializeField] private Image colorDisplay;

    private void OnEnable()
    {
        ColorObject.OnChangeColor += UpdateColorUI;
    }

    private void OnDisable()
    {
        ColorObject.OnChangeColor -= UpdateColorUI;
    }

    private void UpdateColorUI(Color newColor)
    {
        colorDisplay.color = newColor;
    }
}
