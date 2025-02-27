using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) 
        {
            AudioManager.Instance.stopSfx();
            AudioManager.Instance.playDeathSound();
            RestartScene();
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
