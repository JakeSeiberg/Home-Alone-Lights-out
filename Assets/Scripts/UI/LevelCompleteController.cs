using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteController : MonoBehaviour
{
    public void OnMainMenu(){
        SceneManager.LoadScene(0);
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void OnNextLevel(){
        MainMenuController.curLevel++;
        SceneManager.LoadScene(MainMenuController.curLevel);
    }
}
