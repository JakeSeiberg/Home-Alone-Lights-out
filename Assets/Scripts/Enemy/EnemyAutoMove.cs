using UnityEngine;

public class EnemyAutoMove : MonoBehaviour
{
    public float speed = 2f; // Speed of movement
    public Transform[] points; // Array of movement positions (Can be 2, 3, or more)
    
    private int targetIndex = 0; // Current target index
    private SpriteRenderer spriteRenderer;
    private bool movingLeft;

    void Start()
    {
        if (points.Length == 0)
        {
            Debug.LogError("No points assigned to EnemyAutoMove script!");
            return;
        }

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (points.Length > 0)
        {
            Move();
        }
    }

    void Move()
    {
        // Move towards current target point
        transform.position = Vector3.MoveTowards(transform.position, points[targetIndex].position, speed * Time.deltaTime);

        // Determine sprite flipping direction
        movingLeft = points[targetIndex].position.x < transform.position.x;
        spriteRenderer.flipX = movingLeft;

        // Check if reached target position
        if (Vector3.Distance(transform.position, points[targetIndex].position) < 0.1f)
        {
            // Move to next point in sequence
            targetIndex++;

            // If we reached the last point, go back to the first
            if (targetIndex >= points.Length)
            {
                targetIndex = 0; // Restart cycle
            }
        }
    }
}
