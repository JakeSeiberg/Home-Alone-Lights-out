using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private bool checkMoving;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        checkMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        handleMovement();

        /*if(checkMoving){
            AudioManager.Instance.playFootstepSound();
            checkMoving = false;
        }*/
        
    }

    void handleMovement(){
        Vector3 pos = transform.position;
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            pos.x += speed * Time.deltaTime;
            checkMoving = true;
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            pos.x -= speed * Time.deltaTime;
            checkMoving = true;
        }
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            pos.y += speed * Time.deltaTime;
            checkMoving = true;
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            pos.y -= speed * Time.deltaTime;
            checkMoving = true;
        }  
        
        transform.position = pos;
    }

}
