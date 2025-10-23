using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public event Action<int> OnCoinUpdate;
    public event Action<int> OnLifeUpdate;

    private int coins = 0;
    private int life = 3;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GainCoin()
    {
        coins++;
        OnCoinUpdate?.Invoke(coins);
    }

    public void ModifyLife(int amount)
    {
        life += amount;
        OnLifeUpdate?.Invoke(life);
    }
}
