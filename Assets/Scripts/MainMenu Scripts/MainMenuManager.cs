using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    private bool isOptionsOpen = false;
    [SerializeField] private ScenesManager sceneManager;
    [SerializeField] private GameObject optionsScreen;
    //[SerializeField] private GameObject mainMenu;
    //[SerializeField] private AudioSource buttonPress;

    public void ToggleSoundSettings()
    {
        if (!isOptionsOpen) //turn on audio settings
        {
            optionsScreen.SetActive(true);
            //mainMenu.SetActive(false);
            isOptionsOpen = true;
        }
        else if (isOptionsOpen) //turn off audio settings
        {
            optionsScreen.SetActive(false);
            //mainMenu.SetActive(true);
            isOptionsOpen = false;
        }
        //buttonPress.Play();
    }

    public void EnterMainStage()
    {
        sceneManager.EnterMainStage();
    }

}
