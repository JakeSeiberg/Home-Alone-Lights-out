using UnityEngine;
using UnityEngine.AI;


public class LightTime : MonoBehaviour
{
    public static float maxTime = 8f;
    private SpriteRenderer _lightSpriteRenderer;
    public Sprite[] timerSprites;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _lightSpriteRenderer = GetComponent<SpriteRenderer>();
        maxTime = 8f;
    }

    // Update is called once per frame
    void Update()
    {
        if (maxTime > 7 && maxTime < 8){
            _lightSpriteRenderer.sprite = timerSprites[0];
        }
        if (maxTime > 6 && maxTime <= 7){
            _lightSpriteRenderer.sprite = timerSprites[1];
        }
        if (maxTime > 5 && maxTime <= 6){
            _lightSpriteRenderer.sprite = timerSprites[2];
        }
        if (maxTime > 4 && maxTime <= 5){
            _lightSpriteRenderer.sprite = timerSprites[3];
        }
        if (maxTime > 3 && maxTime <= 4){
            _lightSpriteRenderer.sprite = timerSprites[4];
        }
        if (maxTime > 2 && maxTime <= 3){
            _lightSpriteRenderer.sprite = timerSprites[5];
        }
        if (maxTime > 1 && maxTime <= 2){
            _lightSpriteRenderer.sprite = timerSprites[6];
        }
        if (maxTime > 0 && maxTime <= 1){
            _lightSpriteRenderer.sprite = timerSprites[6];
        }
        if (maxTime <= 0){
            _lightSpriteRenderer.enabled = false;
        }
    }
    public static void LightConsumed(){
        maxTime -= Time.deltaTime;
        
    }
}
