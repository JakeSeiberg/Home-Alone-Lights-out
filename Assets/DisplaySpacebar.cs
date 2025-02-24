using UnityEngine;

public class DisplaySpacebar : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject
    public float offset = -5f; //


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null && PlayerRoomTracker.playerCurrentRoomIndex == 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
                Vector3 playerPosition = player.transform.position;
                Vector3 spacebarPosition = new Vector3(playerPosition.x, playerPosition.y + offset, playerPosition.z);
                transform.position = spacebarPosition;
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
