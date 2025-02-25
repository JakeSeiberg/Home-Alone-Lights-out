using UnityEngine;

public class LeverTracker : MonoBehaviour
{
    public static bool[] leversSwitched;
    public int numberOfRooms;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        leversSwitched = new bool[numberOfRooms];
        for (int i = 0; i < numberOfRooms; i++)
        {
            leversSwitched[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(string.Join(" ", leversSwitched));
    }

    public static void resetLevers(){
        for (int i = 0; i < leversSwitched.Length; i++)
        {
            leversSwitched[i] = false;
        }
    }
}
