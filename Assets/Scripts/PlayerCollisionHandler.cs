using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    private PlayerModel playerModel;

    public void Initialize(PlayerModel model)
    {
        playerModel = model;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerModel.ChangeHealth(-10);
        }
    }
}