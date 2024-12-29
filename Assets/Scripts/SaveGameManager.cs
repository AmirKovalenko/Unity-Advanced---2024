using UnityEngine;

[System.Serializable] //can view in inspector debug mode
public class SaveGameManager : MonoBehaviour
{
    const string SAVE_FILE_NAME = "/Save.dat";
    [SerializeField] GameManager gameManager;
    [SerializeField] UIManager uiManager;

    SerializedSaveGame serializedSaveGame;

    [ContextMenu("SAVE!")]
    public void SaveGame()
    {
        serializedSaveGame = new SerializedSaveGame();
        // serializedSaveGame.playerPosition = gameManager.playerCharacterController.transform.position;
        // serializedSaveGame.playerRotation = gameManager.playerCharacterController.transform.eulerAngles;
        serializedSaveGame.playerPositionX = gameManager.playerCharacterController.transform.position.x;
        serializedSaveGame.playerPositionY = gameManager.playerCharacterController.transform.position.y;
        serializedSaveGame.playerPositionZ = gameManager.playerCharacterController.transform.position.z;

        serializedSaveGame.playerRotationX = gameManager.playerCharacterController.transform.eulerAngles.x;
        serializedSaveGame.playerRotationY = gameManager.playerCharacterController.transform.eulerAngles.y;
        serializedSaveGame.playerRotationZ = gameManager.playerCharacterController.transform.eulerAngles.z;

        //serializedSaveGame.playerHP = gameManager.playerCharacterController.Hp;
        //serializedSaveGame.currentWaypointIndex = gameManager.playerCharacterController.CurrentWaypointIndex;

        //     SaveToJson();
        //SaveToBinary();
    }

    [ContextMenu("LOAD!")]
    public void LoadGame()
    {

    }
}
