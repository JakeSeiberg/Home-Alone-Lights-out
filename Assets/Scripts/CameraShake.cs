using UnityEngine;
using Unity.Cinemachine;
using System.Collections;
using Unity.VisualScripting;
using System;
using System.Linq;

public class CameraShake : MonoBehaviour
{
    public CinemachineCamera vCam;
    public GameObject player;
    public GameObject[] enemies;
    public GameObject outDistance;
    private CinemachineBasicMultiChannelPerlin noise;

    public float minNoise = 1;
    public float[] distance;


    void Start()
    {
        noise = vCam.GetComponentInChildren<CinemachineBasicMultiChannelPerlin>();
    }

    void Update()
    {   
        ClosestMonster();
        CShake(distance.Min());
    }

    void ClosestMonster(){

        for (int i = 0; i < enemies.Length; i++){
            if (!enemies[i].activeSelf)
            {
                enemies[i] = outDistance;
            }
            else{
                Vector2 a = new Vector2(player.transform.position.x, player.transform.position.y);
                Vector2 b = new Vector2(enemies[i].transform.position.x, enemies[i].transform.position.y);
                distance[i] = Vector2.Distance(a, b);
            }
        }
    }

    void CShake(float closestMonster){ 
        //TODO: check monster tag for room location, if room lever is switched, remove from array
        if (closestMonster <= 3 && closestMonster > 2){
            noise.FrequencyGain = 1;
        }
        else if (closestMonster <= 2 && closestMonster > 1.5){
            noise.FrequencyGain = 2;
        }
        else if (closestMonster <= 1.5 && closestMonster > 0){
            noise.FrequencyGain = 3;
        }
        else {
            noise.FrequencyGain = 0;
        }
    }
}
