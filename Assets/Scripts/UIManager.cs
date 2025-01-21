using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI hpText;

    [SerializeField] private PlayerCharacterController playerRef;

    public void RefreshHPText(int newHP)
    {
        hpText.text = newHP.ToString();
    }

    private void Start()
    {
        hpText.text = playerRef.Hp.ToString();
        playerRef.onTakeDamageEvent.AddListener(RefreshHPText);
    }


}