using UnityEngine;

public class LevelResetOnReload : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LeverTracker.resetLevers();
        DisplayShift.resetBools();
        PlayerRoomTracker.SetPlayerRoomIndex(0);

    }

}
