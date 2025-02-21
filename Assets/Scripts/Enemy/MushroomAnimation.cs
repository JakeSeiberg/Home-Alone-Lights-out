using UnityEngine;

public class EnemyAnimationController : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        animator = GetComponent<Animator>(); // Get Animator
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get SpriteRenderer
    }

    public void SetMoving(bool isMoving, float directionX)
    {
        animator.SetBool("isMoving", isMoving); // Start or stop walking animation

        // Flip sprite if moving left
        if (directionX < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (directionX > 0)
        {
            spriteRenderer.flipX = false;
        }
    }
}
