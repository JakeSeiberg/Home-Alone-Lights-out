using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    static public int curLevel;

    public void OnQuit(){
        Application.Quit();     
    }

    public void OnTutorial(){
        curLevel = 1;
        SceneManager.LoadScene(1);
    }

    public void OnLeveOne(){
        curLevel = 2;
        SceneManager.LoadScene(2);
    }

    public void OnLevelTwo()
    {
        curLevel = 3;
        SceneManager.LoadScene(3);
    }

    public void OnLevelThree(){
        curLevel = 4;
        SceneManager.LoadScene(4);
    }

}
