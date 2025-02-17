using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator playerAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        checkWalk();
    }

    void checkWalk(){
        if(Input.GetKey(KeyCode.A)){
            playerAnimator.SetBool("IsAPress", true);
        }
        else{
            playerAnimator.SetBool("IsAPress", false);
        }

        if(Input.GetKey(KeyCode.D)){
            playerAnimator.SetBool("IsDPress", true);
        }
        else{
            playerAnimator.SetBool("IsDPress", false);
        }

        if(Input.GetKey(KeyCode.S)){
            playerAnimator.SetBool("IsSPress", true);
        }
        else{
            playerAnimator.SetBool("IsSPress", false);
        }

        if(Input.GetKey(KeyCode.W)){
            playerAnimator.SetBool("IsWPress", true);
        }
        else{
            playerAnimator.SetBool("IsWPress", false);
        }
        
    }
}
