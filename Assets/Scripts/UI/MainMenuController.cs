using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public void OnQuit(){
        Application.Quit();     
    }

    public void OnTutorial(){
        SceneManager.LoadScene(1);
    }

    public void OnLeveOne(){
        SceneManager.LoadScene(2);
    }

    public void OnLevelTwo()
    {
        SceneManager.LoadScene(3);
    }

    public void OnLevelThree(){
        SceneManager.LoadScene(4);
    }
}
