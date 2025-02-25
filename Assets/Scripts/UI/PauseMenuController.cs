using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{

    public void OnMainMenu(){
        SceneManager.LoadScene(0);
    }

    public void testButton(){
        Debug.Log("click");
    }

}
