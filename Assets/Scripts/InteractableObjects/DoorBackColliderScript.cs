using UnityEngine;
using System.Collections;

public class DoorBackColliderScript : MonoBehaviour
{

    public GameObject player;
    public int roomIndexAfterTeleport;

    private bool playerInRange = false;

    private Vector2 teleportOffset;
    public GameObject door;
    
    void Start()
    {
        teleportOffset.x = -4.20183f;
        teleportOffset.y = 2.95f;
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
        if (playerInRange && (Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift)))
        {
            StartCoroutine(teleportDoor());
            AudioManager.Instance.playDoorSound();
        }
        //Debug.Log(string.Join(" ", leversSwitched));

    }

    IEnumerator teleportDoor()
    {   
        yield return new WaitForSeconds(.5f); // Wait before changing

        
        Vector3 newPosition = door.transform.position;
        newPosition.x += teleportOffset.x;  // Set the X position
        newPosition.y += teleportOffset.y;  // Set the Y position
        player.transform.localPosition = newPosition;  // Apply the new position
        PlayerRoomTracker.SetPlayerRoomIndex(roomIndexAfterTeleport);
    }

}
