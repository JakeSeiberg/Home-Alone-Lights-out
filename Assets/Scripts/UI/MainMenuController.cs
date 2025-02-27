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
        SceneManager.LoadScene(2);
    }

    public void OnLeveOne(){
        curLevel = 4;
        AudioManager.Instance.playMenuClick();
        SceneManager.LoadScene(4);
    }

    public void OnLevelTwo()
    {
        curLevel = 5;
        AudioManager.Instance.playMenuClick();
        SceneManager.LoadScene(5);
    }

    public void OnLevelThree(){
        curLevel = 6;
        AudioManager.Instance.playMenuClick();
        SceneManager.LoadScene(6);
    }

}
