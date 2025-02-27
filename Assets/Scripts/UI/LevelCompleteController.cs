using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteController : MonoBehaviour
{
    void Start()
    {
        AudioManager.Instance.playLevelComplete();
    }
    public void OnMainMenu(){
        AudioManager.Instance.playMenuClick();
        SceneManager.LoadScene(0);
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void OnNextLevel(){
        AudioManager.Instance.playMenuClick();
        MainMenuController.curLevel++;
        SceneManager.LoadScene(MainMenuController.curLevel);
    }
}
