using UnityEngine;

public class DisplayShift : MonoBehaviour
{
    public static bool[] shiftColliders = {false, false, false};
    public float offset = -1.2f; //

    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public static void showShift(int colliderIndex){
        
    }

    void Update()
    {
        print(shiftColliders[0]);
        print(shiftColliders[0]);
        print(shiftColliders[0]);
        print("reset");
        if (shiftColliders[0] || shiftColliders[1] || shiftColliders[2]){
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            Vector3 playerPosition = player.transform.position;
            Vector3 spacebarPosition = new Vector3(playerPosition.x + offset, playerPosition.y, playerPosition.z);
            transform.position = spacebarPosition;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        
    }
}
