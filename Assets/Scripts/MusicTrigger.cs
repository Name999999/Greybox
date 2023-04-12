using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public AudioClip[] audioSources;
    public AudioSource randomSound;


    private void Start()
    {
       
            randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
            randomSound.Play();
        
    }
}


