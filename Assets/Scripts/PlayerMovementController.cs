using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private PlayerMovementModel model;
    private PlayerMovementView view;

    public PlayerMovementController(PlayerMovementModel model, PlayerMovementView view)
    {
        this.model = model;
        this.view = view;
    }

    public void HandleInput()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        view.Move(direction, model.speed);
    }
}