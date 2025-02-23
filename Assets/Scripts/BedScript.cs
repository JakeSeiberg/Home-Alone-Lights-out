using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BedScript : MonoBehaviour
{

    private bool playerInRange = false;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Ensure the player has the "Player" tag
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        if (playerInRange && (Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift)) && AreAllTrue(LeverTracker.leversSwitched))
        {
            StartCoroutine(levelComplete());
        }

    }
    
    public static bool AreAllTrue(bool[] boolArray)
    {
        foreach (bool value in boolArray)
        {
            if (!value)  // If any value is false, return false
                return false;
        }
        return true;  // If all values are true
    }

    IEnumerator levelComplete()
    {   
        yield return new WaitForSeconds(.5f); // Wait before changing

        Debug.Log("Level Complete");
        SceneManager.LoadScene(1);
    }

}
