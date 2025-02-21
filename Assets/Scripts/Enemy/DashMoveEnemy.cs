using UnityEngine;
using System.Collections;

public class DashMoveEnemy : MonoBehaviour
{
    public float normalSpeed = 2f; // Speed while moving normally
    public float dashSpeed = 6f;   // Speed while dashing
    public float idleTime = 1.5f;  // Time to wait before dashing

    public Transform pointA; // First position
    public Transform pointB; // Second position

    private Vector3 targetPosition;
    private SpriteRenderer spriteRenderer;
    private bool movingLeft;
    private bool isDashing = false; // Track if enemy is dashing

    void Start()
    {
        targetPosition = pointA.position;
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Start the movement coroutine
        StartCoroutine(DashRoutine());
    }

    void Update()
    {
        spriteRenderer.flipX = movingLeft;
    }

    void Move(float speed)
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Determine direction for sprite flipping
        movingLeft = targetPosition.x < transform.position.x;

        // Check if reached the target position
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            isDashing = false;
            StartCoroutine(DashRoutine());
        }
    }

    IEnumerator DashRoutine()
    {
        // Wait before dashing
        yield return new WaitForSeconds(idleTime);

        // Switch target position
        targetPosition = (targetPosition == pointA.position) ? pointB.position : pointA.position;

        // Dash to the target
        isDashing = true;

        while (isDashing)
        {
            Move(dashSpeed); // Move at dash speed
            yield return null; // Wait until next frame
        }
    }
}
