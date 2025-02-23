using UnityEngine;

public class LeverTracker : MonoBehaviour
{
    public static bool[] leversSwitched = {false, false};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(string.Join(" ", leversSwitched));
    }

    public static void resetLevers(){ //temporary fix
        leversSwitched[0] = false;
        leversSwitched[1] = false;
    }
}
