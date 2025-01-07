using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    PlayerCharacterController playerRef;
    [SerializeField] TextMeshProUGUI playerHPText;
    int playerHP = 100;

    void Start()
    {
        playerRef = FindFirstObjectByType<PlayerCharacterController>();
        RefreshHPText();
    }
    
    public void TakeDamage(int damageAmount)
    {
        playerHP -= damageAmount;
        RefreshHPText();

        //onTakeDamageEvent.Invoke(playerHP);
        //onTakeDamageEventAction.Invoke(playerHP);

        if (playerHP < 0) 
        {
            //playerRef.playerGO.SetActive(false);
            Debug.Log("u died lol");
        }
    }

    public void RefreshHPText()
    {
        playerHPText.text = playerHP.ToString();
    }
}
