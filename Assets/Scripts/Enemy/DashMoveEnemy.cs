// using UnityEngine;
// using System.Collections;

// public class DashMoveEnemy : MonoBehaviour
// {
//     public float normalSpeed = 2f; // Speed while moving normally
//     public float dashSpeed = 6f;   // Speed while dashing
//     public float idleTime = 1.5f;  // Time to wait before dashing

//     public Transform pointA; // First position
//     public Transform pointB; // Second position

//     private Vector3 targetPosition;
//     private SpriteRenderer spriteRenderer;
//     private bool movingLeft;
//     private bool isDashing = false; // Track if enemy is dashing

//     void Start()
//     {
//         targetPosition = pointA.position;
//         spriteRenderer = GetComponent<SpriteRenderer>();

//         // Start the movement coroutine
//         StartCoroutine(DashRoutine());
//     }

//     void Update()
//     {
//         spriteRenderer.flipX = movingLeft;
//     }

//     void Move(float speed)
//     {
//         transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

//         // Determine direction for sprite flipping
//         movingLeft = targetPosition.x < transform.position.x;

//         // Check if reached the target position
//         if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
//         {
//             isDashing = false;
//             StartCoroutine(DashRoutine());
//         }
//     }

//     IEnumerator DashRoutine()
//     {
//         // Wait before dashing
//         yield return new WaitForSeconds(idleTime);

//         // Switch target position
//         targetPosition = (targetPosition == pointA.position) ? pointB.position : pointA.position;

//         // Dash to the target
//         isDashing = true;

//         while (isDashing)
//         {
//             Move(dashSpeed); // Move at dash speed
//             yield return null; // Wait until next frame
//         }
//     }
// }


using UnityEngine;
using System.Collections;

public class DashingEnemy : MonoBehaviour
{
    public float dashSpeed = 6f;  // Speed when dashing
    public float idleTime = 1.5f; // Time to wait before dashing
    public Transform[] points;    // Array of movement positions

    public int roomIndex;

    private int targetIndex = 0; // Current target in the sequence
    private bool isDashing = false;
    private SpriteRenderer spriteRenderer;
    private bool movingLeft;

    void Start()
    {
        if (points.Length == 0)
        {
            Debug.LogError("No points assigned to DashingEnemy script!");
            return;
        }

        spriteRenderer = GetComponent<SpriteRenderer>();
        transform.position = points[0].position; // Start at the first point
        StartCoroutine(DashRoutine());
    }

    void Update()
    {
        if (points.Length > 0)
        {
            spriteRenderer.flipX = movingLeft;
        }

        if (LeverTracker.leversSwitched[roomIndex] == true)
        {
            gameObject.SetActive(false);
        }
    }

    IEnumerator DashRoutine()
    {
        while (true) // Loop forever
        {
            yield return new WaitForSeconds(idleTime); // Wait before dashing

            int nextIndex = (targetIndex + 1) % points.Length; // Get next point in sequence
            Vector3 targetPosition = points[nextIndex].position;

            isDashing = true;
            while (Vector3.Distance(transform.position, targetPosition) > 0.1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, dashSpeed * Time.deltaTime);
                movingLeft = targetPosition.x < transform.position.x;
                yield return null; // Wait for the next frame
            }
            
            isDashing = false;
            targetIndex = nextIndex; // Move to the next point in sequence
        }
    }
}
