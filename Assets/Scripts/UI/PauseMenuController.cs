using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    void OnControls(){

    }

    void OnMainMenu(){
        SceneManager.LoadScene(0);
    }

}
