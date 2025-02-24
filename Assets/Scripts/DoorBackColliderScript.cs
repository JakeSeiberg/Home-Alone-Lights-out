using UnityEngine;
using System.Collections;

public class DoorBackColliderScript : MonoBehaviour
{

    public GameObject player;
    public float teleportX;
    public float teleportY;
    public int roomIndexAfterTeleport;

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
        if (playerInRange && (Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift)))
        {
            StartCoroutine(teleportDoor());
        }
        //Debug.Log(string.Join(" ", leversSwitched));

    }

    IEnumerator teleportDoor()
    {   
        yield return new WaitForSeconds(.5f); // Wait before changing

        
        Vector3 newPosition = player.transform.position;
        newPosition.x = teleportX;  // Set the X position
        newPosition.y = teleportY;  // Set the Y position
        player.transform.localPosition = newPosition;  // Apply the new position
        PlayerRoomTracker.SetPlayerRoomIndex(0);
    }

}
