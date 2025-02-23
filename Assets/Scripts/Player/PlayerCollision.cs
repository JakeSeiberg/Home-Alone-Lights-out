using UnityEngine;
using UnityEngine.SceneManagement; // Needed for scene management

public class PlayerCollision : MonoBehaviour
{
    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     Debug.Log("Collision detected with: " + collision.gameObject.name);
    //     RestartScene();
    // }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Detected with: " + collision.gameObject.name); // Debug to check collisions

        if (collision.gameObject.CompareTag("Enemy")) // Make sure enemy has the correct tag
        {
            Debug.Log("Player hit the enemy! Restarting scene...");
            RestartScene();
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the scene
    }
}
