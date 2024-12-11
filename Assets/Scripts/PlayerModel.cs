using System;
using UnityEngine;

public class PlayerModel
{
    public event Action<int> OnHealthChange;
    public event Action OnPlayerDeath;

    private int maxHealth;
    private int currentHealth;

    public PlayerModel(int maxHealth)
    {
        this.maxHealth = maxHealth;
        currentHealth = maxHealth;
    }

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        OnHealthChange?.Invoke(currentHealth);

        if (currentHealth <= 0)
        {
            OnPlayerDeath?.Invoke();
        }
    }
}