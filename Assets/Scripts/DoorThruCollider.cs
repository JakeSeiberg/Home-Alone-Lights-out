using UnityEngine;
using System.Collections;

public class DoorThruCollider : MonoBehaviour
{

    public SpriteRenderer doorSpriteRenderer; // Assign in Inspector
    public Sprite[] doorSprites; // Assign multiple sprites in Inspector
    public float frameDelay = 0.12f; // Time between frames

    public GameObject player;

    private bool playerInRange = false;
    
    private bool hasOpened = false;


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
        if (playerInRange && (Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift)) && LeverTracker.leversSwitched[0] == true)
        {
            StartCoroutine(PlayDoorAnimation());
        }
        //Debug.Log(string.Join(" ", leversSwitched));

    }
    
    IEnumerator PlayDoorAnimation()
    {
        
        if (!hasOpened){
            hasOpened = true;
            for (int i = 0; i < doorSprites.Length; i++)
            {
                doorSpriteRenderer.sprite = doorSprites[i]; // Change sprite
                yield return new WaitForSeconds(frameDelay); // Wait before changing
            }

        }
        
        yield return new WaitForSeconds(.5f); // Wait before changing

        
        Vector3 newPosition = player.transform.position;
        newPosition.x = -2.61f;  // Set the X position
        newPosition.y = 16.12f;  // Set the Y position
        player.transform.localPosition = newPosition;  // Apply the new position

    }

}
