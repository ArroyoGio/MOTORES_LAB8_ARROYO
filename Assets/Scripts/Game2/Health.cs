using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int lifeRecover = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.ModifyLife(lifeRecover);
            }
            else
            {
                Debug.LogWarning("GameManager no encontrado al recoger vida.");
            }

            Destroy(gameObject);
        }
    }
}
