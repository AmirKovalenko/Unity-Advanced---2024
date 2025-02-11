using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI hpText;
    [SerializeField] private PlayerCharacterController playerRef;

    [SerializeField] private GameObject audioScreenGO;
    private bool isAudioScreenOpen;

    public void RefreshHPText(int newHP)
    {
        hpText.text = newHP.ToString();
    }

    private void Awake()
    {
        playerRef.onTakeDamageEventAction += RefreshHPText; //Unity action
    }

    private void Start()
    {
        hpText.text = playerRef.Hp.ToString();
        playerRef.onTakeDamageEvent.AddListener(RefreshHPText);
    }

    public void ToggleAudioSettings()
    {
        if (!isAudioScreenOpen)
        {
            audioScreenGO.SetActive(true);
            isAudioScreenOpen = true;
        }
        else if (isAudioScreenOpen)
        {
            audioScreenGO.SetActive(false);
            isAudioScreenOpen = false;
        }
    }
}