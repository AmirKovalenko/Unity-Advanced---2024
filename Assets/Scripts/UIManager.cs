using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    FakePlayerMovement tempMovement;
    [SerializeField] TextMeshProUGUI playerHPText;
    int playerHP = 100;

    void Start()
    {
        tempMovement = FindFirstObjectByType<FakePlayerMovement>();
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
            tempMovement.player.SetActive(false);
            Debug.Log("u died lol");
        }
    }

    public void RefreshHPText()
    {
        playerHPText.text = playerHP.ToString();
    }
}
