using UnityEngine;

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
        if(Input.GetKey(KeyCode.D)){
            pos.x += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A)){
            pos.x -= speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.W)){
            pos.y += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S)){
            pos.y -= speed * Time.deltaTime;
        }  
        
        transform.position = pos;
    }
}
