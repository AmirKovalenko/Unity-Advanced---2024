using UnityEngine;

[System.Serializable] //can view in inspector debug mode
public class SerializedSaveGame : MonoBehaviour
{
    public float gameVersion;
    // public Vector3 playerPosition;
    // public Vector3 playerRotation;
    public int playerHP;
    public int currentWaypointIndex;

    public float playerPositionX, playerPositionY, playerPositionZ;
    public float playerRotationX, playerRotationY, playerRotationZ;

}
