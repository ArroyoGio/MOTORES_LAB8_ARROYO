using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.GainCoin();
            }
            else
            {
                Debug.LogWarning("GameManager no encontrado al recoger moneda.");
            }

            Destroy(gameObject);
        }
    }
}
