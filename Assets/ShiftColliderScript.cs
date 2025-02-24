using UnityEngine;

public class ShiftColliderScript : MonoBehaviour
{
    public int colliderIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DisplayShift.shiftColliders[colliderIndex] = true;
        }
    }




    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DisplayShift.shiftColliders[colliderIndex] = false;
        }
    }

}
