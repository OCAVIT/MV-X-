using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    public GameObject playerPrefab;

    private PlayerController playerController;
    private PlayerMovementController playerMovementController;

    private void Start()
    {
        var playerModel = new PlayerModel(100);

        var playerInstance = Instantiate(playerPrefab);
        var playerView = playerInstance.GetComponent<PlayerView>();
        var playerMovementView = playerInstance.GetComponent<PlayerMovementView>();
        var collisionHandler = playerInstance.GetComponent<PlayerCollisionHandler>();

        playerController = new PlayerController(playerModel, playerView);

        var playerMovementModel = new PlayerMovementModel();
        playerMovementController = new PlayerMovementController(playerMovementModel, playerMovementView);

        collisionHandler.Initialize(playerModel);
    }

    private void Update()
    {
        playerMovementController.HandleInput();
    }
}