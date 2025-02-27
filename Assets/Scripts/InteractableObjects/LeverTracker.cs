using UnityEngine;

public class LeverTracker : MonoBehaviour
{
    public static bool[] leversSwitched;
    public int numberOfRooms;
    private bool yawnCheck;
    private float time;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yawnCheck = false;
        time = Time.time;

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
        for (int i = 0; i < numberOfRooms; i++){
            if (!leversSwitched[i]){
                yawnCheck = false;
            }
            else{
                yawnCheck = true;
            }
        }

        if(yawnCheck && Time.time - time > 10){
            AudioManager.Instance.playYawnSound();
            time = Time.time;
        }

    }

    public static void resetLevers(){
        for (int i = 0; i < leversSwitched.Length; i++)
        {
            leversSwitched[i] = false;
        }
    }
}
