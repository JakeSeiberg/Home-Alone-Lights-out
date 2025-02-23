using UnityEngine;
using System.Collections;

public class DoorThruCollider : MonoBehaviour
{

    public SpriteRenderer doorSpriteRenderer; // Assign in Inspector
    public Sprite[] doorSprites; // Assign multiple sprites in Inspector
    public float frameDelay = 0.12f; // Time between frames

    private bool playerInRange = false;
    private bool isAnimating = false;
    
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
        if (playerInRange && (Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift)) && !isAnimating && !hasOpened)
        {
            StartCoroutine(PlayDoorAnimation());
        }
        //Debug.Log(string.Join(" ", leversSwitched));

    }

    IEnumerator PlayDoorAnimation()
    {
        isAnimating = true; // Prevent retriggering animation
        hasOpened = true;
        //leversSwitched[leverIndex] = true;


        for (int i = 0; i < doorSprites.Length; i++)
        {
            doorSpriteRenderer.sprite = doorSprites[i]; // Change sprite
            yield return new WaitForSeconds(frameDelay); // Wait before changing
        }

        isAnimating = false; // Allow re-triggering
        yield return new WaitForSeconds(.5f); // Wait before changing
        //teleport player
    }

}
