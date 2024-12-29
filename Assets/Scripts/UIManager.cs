using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    PlayerCharacterController playerCharController;
    [SerializeField] TextMeshProUGUI playerHPText;
    int playerHP = 100;

    void Start()
    {
        playerCharController = FindFirstObjectByType<PlayerCharacterController>();
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
            playerCharController.playerGO.SetActive(false);
            Debug.Log("u died lol");
        }
    }

    public void RefreshHPText()
    {
        playerHPText.text = playerHP.ToString();
    }
}
