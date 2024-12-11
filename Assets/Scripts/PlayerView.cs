using UnityEngine;
using UnityEngine.UI;

public class PlayerView : MonoBehaviour
{
    public Text healthText;
    public SpriteRenderer spriteRenderer;

    public void UpdateHealthText(int health)
    {
        healthText.text = "HP: " + health;
    }

    public void UpdatePlayerAppearance()
    {
        spriteRenderer.color = Color.red;
    }
}