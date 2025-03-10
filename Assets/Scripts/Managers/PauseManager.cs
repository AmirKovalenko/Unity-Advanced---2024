using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] OptionsManager optionsManager; //used to switch the bool of audio settings
    private bool isGamePaused = false;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject pauseButton;

    public void TogglePause()
    {
        if (!isGamePaused)  //pauses the game
        {
            //areControlsLocked = true;
            isGamePaused = true;
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
            pauseButton.SetActive(false);
        }
        else if (isGamePaused) //unpauses the game
        {
            //areControlsLocked = false;
            isGamePaused = false;
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
            pauseButton.SetActive(true);

            if (optionsManager.isOptionsOpen) //closes the audio screen 
                optionsManager.ToggleOptions();
        }
    }
}
