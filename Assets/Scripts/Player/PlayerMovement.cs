using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        handleMovement();
    }

    void handleMovement(){
        Vector3 pos = transform.position;
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            pos.x += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            pos.x -= speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            pos.y += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            pos.y -= speed * Time.deltaTime;
        }  
        
        transform.position = pos;
    }
}
