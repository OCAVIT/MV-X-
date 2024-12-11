using UnityEngine;

public class PlayerController
{
    private PlayerModel model;
    private PlayerView view;

    public PlayerController(PlayerModel model, PlayerView view)
    {
        this.model = model;
        this.view = view;

        model.OnHealthChange += view.UpdateHealthText;
        model.OnPlayerDeath += HandlePlayerDeath;
    }

    private void HandlePlayerDeath()
    {
        view.UpdatePlayerAppearance();
    }
}