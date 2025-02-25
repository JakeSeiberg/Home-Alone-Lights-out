using UnityEngine;

public class PauseMenuKeyCheck : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame

    public GameObject pauseMenu;
    private bool held;

    void Start()
    {
        held = false;
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape) && !held && pauseMenu.activeSelf){
            pauseMenu.SetActive(false);    
            held = true; 
        }
        else if(Input.GetKey(KeyCode.Escape) && !held && !pauseMenu.activeSelf){
            pauseMenu.SetActive(true);
            held = true;
        }
        else{
            held = false;
        }

        
    }

}
