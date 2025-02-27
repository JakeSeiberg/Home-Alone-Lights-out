using System;
using UnityEngine;
using UnityEngine.Rendering;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Sound[] musicSounds, footstepSfx, deathSfx, doorSfx, lightSfx, monsterSfx, yawnSfx, levelCompleteSfx, menuClickSfx;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    void Start()
    {
        playMusic("Theme");
    }


    public void stopSfx(){
        sfxSource.Stop();
    }

    public void playMusic(string name){
        Sound s = Array.Find(musicSounds, tmp => tmp.name == name);

        if(s == null){
            Debug.Log("Sound does not exist");
        }
        else{
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void playMenuClick(){
        Sound s = menuClickSfx[0];

        if(s == null){
            Debug.Log("Sound does not exist");
        }
        else{
            sfxSource.PlayOneShot(s.clip);
        }
    }
    public void playFootstepSound(){
        int idx = UnityEngine.Random.Range(0,2);

        Sound s = footstepSfx[idx];

        if(s == null){
            Debug.Log("Sound does not exist");
        }
        else{
            sfxSource.PlayOneShot(s.clip);
        }
        
    }

    public void playDeathSound(){
        int idx = UnityEngine.Random.Range(0,2);

        Sound s = deathSfx[idx];

        if(s == null){
            Debug.Log("Sound does not exist");
        }
        else{
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void playDoorSound(){
        int idx = UnityEngine.Random.Range(0,3);

        Sound s = doorSfx[idx];

        if(s == null){
            Debug.Log("Sound does not exist");
        }
        else{
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void playLightSound(){

        Sound s = lightSfx[0];

        if(s == null){
            Debug.Log("Sound does not exist");
        }
        else{
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void playMonsterSound(){
        int idx = UnityEngine.Random.Range(0,6);

        Sound s = monsterSfx[idx];

        if(s == null){
            Debug.Log("Sound does not exist");
        }
        else{
            sfxSource.PlayOneShot(s.clip);
        }
        
    }

    public void playYawnSound(){
        int idx = UnityEngine.Random.Range(0,4);

        Sound s = yawnSfx[idx];

        if(s == null){
            Debug.Log("Sound does not exist");
        }
        else{
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void playLevelComplete(){
        Sound s = levelCompleteSfx[0];

        if(s == null){
            Debug.Log("Sound does not exist");
        }
        else{
            sfxSource.PlayOneShot(s.clip);
        }
    }
}

