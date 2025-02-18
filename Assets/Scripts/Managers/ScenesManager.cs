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
        loadSceneAsyncOperation = SceneManager.LoadSceneAsync("Main Stage", LoadSceneMode.Additive);
    }

    public void VictoryScreen()
    {
        //sceneIndex = 2;
        loadSceneAsyncOperation = SceneManager.LoadSceneAsync("Victory Screen");
    }

    public void DefeatScreen()
    {
        //sceneIndex = 3;
        loadSceneAsyncOperation = SceneManager.LoadSceneAsync("Defeat Screen");
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
