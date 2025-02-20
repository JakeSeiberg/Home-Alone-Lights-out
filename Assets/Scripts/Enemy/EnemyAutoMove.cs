using UnityEngine;

public class EnemyAutoMove : MonoBehaviour
{
    public float speed = 2f; // Speed of movement
    public Transform pointA; // First position
    public Transform pointB; // Second position

    private Vector3 targetPosition;

    private SpriteRenderer spriteRenderer;
    private bool movingLeft;

    void Start()
    {
        targetPosition = pointA.position; // Start moving towards pointA
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Move();
        spriteRenderer.flipX = movingLeft;
    }

    void Move()
    {
        // Move towards target
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (targetPosition.x < transform.position.x) // Moving left
        {
            movingLeft = true;
        }
        else // Moving right
        {
            movingLeft = false;
        }

        spriteRenderer.flipX = movingLeft;

        // Check if reached the target position
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            // Switch target using an if statement
            if (targetPosition == pointA.position)
            {
                targetPosition = pointB.position;
            }
            else
            {
                targetPosition = pointA.position;
            }
        }
    }
}
