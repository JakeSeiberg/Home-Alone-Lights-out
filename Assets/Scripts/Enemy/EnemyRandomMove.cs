using UnityEngine;

public class RandomEnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    public float moveTime = 2f;
    
    public float minX, maxX, minY, maxY; // Boundary limits

    private Vector2 movementDirection;
    private float moveTimer;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PickNewDirection();
    }

    void Update()
    {
        moveTimer -= Time.deltaTime;

        if (moveTimer <= 0)
        {
            PickNewDirection();
        }

        // Clamp position to stay within boundaries
        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, minX, maxX),
            Mathf.Clamp(transform.position.y, minY, maxY)
        );
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movementDirection * speed;
    }

    void PickNewDirection()
    {
        int randomDir = Random.Range(0, 4);
        switch (randomDir)
        {
            case 0: movementDirection = Vector2.up; break;
            case 1: movementDirection = Vector2.down; break;
            case 2: movementDirection = Vector2.left; break;
            case 3: movementDirection = Vector2.right; break;
        }

        moveTimer = moveTime;
    }
}
