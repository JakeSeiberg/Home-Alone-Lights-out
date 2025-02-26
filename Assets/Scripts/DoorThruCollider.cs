using UnityEngine;
using System.Collections;

public class DoorThruCollider : MonoBehaviour
{

    public SpriteRenderer doorSpriteRenderer; // Assign in Inspector
    public Sprite[] doorSprites; // Assign multiple sprites in Inspector
    private float frameDelay = 0.12f; // Time between frames
    public int roomIndexAfterTeleport;

    private Vector2 teleportOffset;
    public GameObject door;

    public GameObject player;

    private bool playerInRange = false;
    
    private bool hasOpened = false;

    void Start()
    {
        teleportOffset.x = -4.20183f;
        teleportOffset.y = 6.33f;
    }

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
        if (playerInRange && (Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift)) && LeverTracker.leversSwitched[PlayerRoomTracker.playerCurrentRoomIndex] == true)
        {
            StartCoroutine(PlayDoorAnimation());
            AudioManager.Instance.playDoorSound();
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

        
        Vector3 newPosition = door.transform.position;
        newPosition.x += teleportOffset.x;  // Set the X position
        newPosition.y += teleportOffset.y;  // Set the Y position
        player.transform.localPosition = newPosition;  // Apply the new position
        PlayerRoomTracker.SetPlayerRoomIndex(roomIndexAfterTeleport);

    }

}
