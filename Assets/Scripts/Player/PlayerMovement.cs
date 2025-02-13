using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Sprite[] characterSprites;
    private SpriteRenderer playerSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();   
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
            playerSprite.sprite = characterSprites[3];
        }
        if(Input.GetKey(KeyCode.A)){
            pos.x -= speed * Time.deltaTime;
            playerSprite.sprite = characterSprites[1];
        }
        if(Input.GetKey(KeyCode.W)){
            pos.y += speed * Time.deltaTime;
            playerSprite.sprite = characterSprites[2];
        }
        if(Input.GetKey(KeyCode.S)){
            pos.y -= speed * Time.deltaTime;
            playerSprite.sprite = characterSprites[0];
        }  
        
        transform.position = pos;
    }
}
