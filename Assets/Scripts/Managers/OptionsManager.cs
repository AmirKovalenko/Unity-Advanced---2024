using UnityEngine;

public class OptionsManager : MonoBehaviour
{
    [SerializeField] private GameObject audioScreenGO;
    [HideInInspector] public bool isOptionsOpen;

    public void ToggleOptions()
    {
        if (!isOptionsOpen) //opens the Options screen
        {
            audioScreenGO.SetActive(true);
            isOptionsOpen = true;
        }
        else if (isOptionsOpen) //closes the Options screen
        {
            audioScreenGO.SetActive(false);
            isOptionsOpen = false;
        }
    }
}
