using TMPro;
using UnityEngine;

public class LifePanel : MonoBehaviour
{
    [SerializeField] private TMP_Text txtLife;

    private void OnEnable()
    {
        GameManager.Instance.OnLifeUpdate += UpdateLife;
    }

    private void OnDisable()
    {
        GameManager.Instance.OnLifeUpdate -= UpdateLife;
    }

    private void UpdateLife(int life)
    {
        txtLife.text = "Vida: " + life;
    }
}
