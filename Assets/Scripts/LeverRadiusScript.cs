using UnityEngine;
using System.Collections;

public class LeverRadiusScript : MonoBehaviour
{
    public bool[] leversSwitched = {false, false};

    public int leverIndex;

    public SpriteRenderer leverSpriteRenderer; // Assign in Inspector
    public Sprite[] leverSprites; // Assign multiple sprites in Inspector
    public float frameDelay = 0.08f; // Time between frames

    private bool playerInRange = false;
    private bool isAnimating = false;
    
    private bool hasSwitched = false;

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
        if (playerInRange && (Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift)) && !isAnimating && !hasSwitched)
        {
            StartCoroutine(PlayLeverAnimation());
        }
        Debug.Log(string.Join(" ", leversSwitched));

    }

    IEnumerator PlayLeverAnimation()
    {
        isAnimating = true; // Prevent retriggering animation
        hasSwitched = true;
        leversSwitched[leverIndex] = true;


        for (int i = 0; i < leverSprites.Length; i++)
        {
            leverSpriteRenderer.sprite = leverSprites[i]; // Change sprite
            yield return new WaitForSeconds(frameDelay); // Wait before changing
        }

        isAnimating = false; // Allow re-triggering
    }

}
