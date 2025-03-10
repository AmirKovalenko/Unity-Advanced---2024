using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    //private int sceneIndex;  //used for restarting Scene
    private AsyncOperation loadSceneAsyncOperation;

    public void EnterMainMenu()
    {
        //sceneIndex = 0;
        loadSceneAsyncOperation = SceneManager.LoadSceneAsync("Main Menu");
    }

    public void EnterMainStage()
    {
        //sceneIndex = 1;
        loadSceneAsyncOperation = SceneManager.LoadSceneAsync("Main Stage");
        Time.timeScale = 1;
    }

    public void VictoryScreen()
    {
        //sceneIndex = 2;
        loadSceneAsyncOperation = SceneManager.LoadSceneAsync("Victory Screen", LoadSceneMode.Additive);
    }

    public void DefeatScreen()
    {
        //sceneIndex = 3;
        loadSceneAsyncOperation = SceneManager.LoadSceneAsync("Defeat Screen", LoadSceneMode.Additive);
    }


    //public void Restart()
    //{
    //    SceneManager.LoadScene(sceneIndex);
    //}

    public void Exit()
    {
        Application.Quit();
    }

}
