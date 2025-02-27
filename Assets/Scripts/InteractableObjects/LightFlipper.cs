using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightFlipper : MonoBehaviour
{
    public Light2D[] levelLights;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            //if the lever of the room that the player is in is on
        if (LeverTracker.leversSwitched[PlayerRoomTracker.playerCurrentRoomIndex] == true){
            //sets intensity to 1
            levelLights[PlayerRoomTracker.playerCurrentRoomIndex].intensity = 1;
        }
        
        /*PlayerRoomTracker.playerCurrentRoomIndex == 
            
        if (LeverTracker.leversSwitched[leverCounter]){
            levelLights[leverCounter].intensity = 1;
            if (!BedScript.AreAllTrue(LeverTracker.leversSwitched))
                leverCounter++;
        }
        */
    }
}
