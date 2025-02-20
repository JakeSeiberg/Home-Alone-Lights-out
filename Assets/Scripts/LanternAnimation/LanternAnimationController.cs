using System.Threading;
using TMPro;
using UnityEngine;

public class LanternAnimationController : MonoBehaviour
{
    private Animator lanternAnimator;
    private bool lanternOnCheck;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lanternAnimator = GetComponent<Animator>();
        lanternOnCheck = false;
    }
    
    void FixedUpdate()
    {
        checkLanternStatus();
    }

    void checkLanternStatus(){
        if(Input.GetKey(KeyCode.Space)){
            lanternOnCheck = true;
            lanternAnimator.SetBool("IsSpacePress", true);
        }
        else{
            lanternOnCheck = false;
            lanternAnimator.SetBool("IsSpacePress", false);
        }

        if(lanternOnCheck && !Input.GetKey(KeyCode.Space)){

            lanternOnCheck = false;
            lanternAnimator.SetBool("IsSpacePress", false);
        }   
    }

}
