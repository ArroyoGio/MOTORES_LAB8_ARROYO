using TMPro;
using UnityEngine;

public class CoinPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text txtCoins;

    private void OnEnable()
    {
        GameManager.Instance.OnCoinUpdate += UpdateCoins;
    }

    private void OnDisable()
    {
        GameManager.Instance.OnCoinUpdate -= UpdateCoins;
    }

    private void UpdateCoins(int coins)
    {
        txtCoins.text = "Monedas: " + coins;
    }
}
