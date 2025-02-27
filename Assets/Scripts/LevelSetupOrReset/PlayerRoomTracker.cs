using UnityEngine;

public class PlayerRoomTracker : MonoBehaviour
{

    public static int playerCurrentRoomIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerCurrentRoomIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //print(playerCurrentRoomIndex);
    }

    public static void SetPlayerRoomIndex(int roomIndex)
    {
        playerCurrentRoomIndex = roomIndex;
    }
}