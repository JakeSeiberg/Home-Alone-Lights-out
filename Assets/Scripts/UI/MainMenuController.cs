using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    static public int curLevel;

    public void OnQuit(){
        Application.Quit();     
    }

    public void OnTutorial(){
        curLevel = 3;
        AudioManager.Instance.playMenuClick();
        LevelsCompleted.currentLevel = 0;
        SceneManager.LoadScene(2);
    }

    public void OnLeveOne(){
        curLevel = 4;
        AudioManager.Instance.playMenuClick();
        LevelsCompleted.currentLevel = 1;
        SceneManager.LoadScene(4);
    }

    public void OnLevelTwo()
    {
        if (LevelsCompleted.levelsCompleted[1])
        {
            curLevel = 5;
            AudioManager.Instance.playMenuClick();
            LevelsCompleted.currentLevel = 2;
            SceneManager.LoadScene(5);
        }
    }

    public void OnLevelThree(){
        if (LevelsCompleted.levelsCompleted[2])
        {
            curLevel = 6;
            AudioManager.Instance.playMenuClick();
            LevelsCompleted.currentLevel = 3;
            SceneManager.LoadScene(6);
        }
        
    }

}
