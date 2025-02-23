using UnityEngine;
using Unity.Cinemachine;
using System.Collections;

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
        float noiseMultiplier = minNoise/distance;
        CShake(noiseMultiplier);
    }

    float ClosestMonster(){
        Vector2 a = new Vector2(player.transform.position.x, player.transform.position.y);
        Vector2 b = new Vector2(enemy.transform.position.x, enemy.transform.position.y);
        float distance = Vector2.Distance(a, b);
        Debug.Log(distance);
        return distance;
    }
    void CShake(float multiplier){
        if (noise.AmplitudeGain * multiplier < 1){
            noise.AmplitudeGain = 1;
        }
        else if (noise.AmplitudeGain * multiplier > 5){
            noise.AmplitudeGain = 5;
        }
        else {
            noise.AmplitudeGain *= multiplier;
        }
        
    }
}
