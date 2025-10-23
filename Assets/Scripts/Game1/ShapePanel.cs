using UnityEngine;
using UnityEngine.UI;

public class ShapePanel : MonoBehaviour
{
    [SerializeField] private Image shapeDisplay;

    private void OnEnable()
    {
        ShapeObject.OnChangeShape += UpdateShapeUI;
    }

    private void OnDisable()
    {
        ShapeObject.OnChangeShape -= UpdateShapeUI;
    }

    private void UpdateShapeUI(Sprite newSprite)
    {
        shapeDisplay.sprite = newSprite;
    }
}
