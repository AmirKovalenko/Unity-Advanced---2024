using UnityEngine;
using UnityEngine.SceneManagement;


public class ScenesManager : MonoBehaviour
{
    private int sceneIndex;
    private AsyncOperation loadSceneAsyncOperation;

    public void EnterMainMenu()
    {
        sceneIndex = 0;
        loadSceneAsyncOperation = SceneManager.LoadSceneAsync("Main Menu");
    }

    public void EnterMainStage()
    {
        sceneIndex = 1;
        loadSceneAsyncOperation = SceneManager.LoadSceneAsync("Main Stage", LoadSceneMode.Additive);
    }

    public void Restart()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
