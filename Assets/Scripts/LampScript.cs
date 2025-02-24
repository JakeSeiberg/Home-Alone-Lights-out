using UnityEngine;

public class LampScript : MonoBehaviour
{
    public SpriteRenderer LampRenderer; // Assign in Inspector
    public Sprite lampLit;
    public int roomIndex;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LeverTracker.leversSwitched[roomIndex] == true)
        {
            LampRenderer.sprite = lampLit;
        }
    }
}
