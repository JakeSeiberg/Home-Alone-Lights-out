using UnityEngine;
using Unity.Cinemachine;
using System.Collections;
using Unity.VisualScripting;

public class CameraShake : MonoBehaviour
{
    public CinemachineCamera vCam;
    public GameObject player;
    public GameObject enemy;
    private CinemachineBasicMultiChannelPerlin noise;

    public float minNoise = 1;


    void Start()
    {
        noise = vCam.GetComponentInChildren<CinemachineBasicMultiChannelPerlin>();
    }

    void Update()
    {
        float distance = ClosestMonster();
        //float noiseMultiplier = minNoise/distance;
        CShake(distance);
    }

    float ClosestMonster(){
        Vector2 a = new Vector2(player.transform.position.x, player.transform.position.y);
        Vector2 b = new Vector2(enemy.transform.position.x, enemy.transform.position.y);
        float distance = Vector2.Distance(a, b);
        Debug.Log(distance);
        return distance;
    }
    void CShake(float multiplier){
        if (multiplier <= 4 && multiplier > 3){
            noise.FrequencyGain = 1;
        }
        else if (multiplier <= 3 && multiplier > 2){
            noise.FrequencyGain = 2;
        }
        else if (multiplier <= 2 && multiplier > 0){
            noise.FrequencyGain = 3;
        }
        else {
            noise.FrequencyGain = 0;
        }
        
    }
}
