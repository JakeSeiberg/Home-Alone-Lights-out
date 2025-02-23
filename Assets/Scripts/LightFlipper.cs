using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightFlipper : MonoBehaviour
{
    public Light2D[] levelLights;
    private int leverCounter = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LeverTracker.leversSwitched[leverCounter]){
            levelLights[leverCounter].intensity = 0;
            if (!BedScript.AreAllTrue(LeverTracker.leversSwitched))
                leverCounter++;
        }
    }
}
