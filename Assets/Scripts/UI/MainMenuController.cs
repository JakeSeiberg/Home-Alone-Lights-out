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
        SceneManager.LoadScene(2);
    }

    public void OnLeveOne(){
        curLevel = 4;
        SceneManager.LoadScene(4);
    }

    public void OnLevelTwo()
    {
        curLevel = 5;
        SceneManager.LoadScene(5);
    }

    public void OnLevelThree(){
        curLevel = 6;
        SceneManager.LoadScene(6);
    }

}
