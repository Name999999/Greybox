using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioClip[] audioSources;
    public AudioSource randomSound;


    private void Start()
    {
       
    }

    public void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
            randomSound.Play();
            Debug.Log("Debug");
        }
        else if (Input.GetKeyDown("a"))
        {
            randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
            randomSound.Play();
        }
        else if (Input.GetKeyDown("s"))
        {
            randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
            randomSound.Play();
        }
        else if (Input.GetKeyDown("d"))
        {
            randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
            randomSound.Play();
        }

        if (Input.GetKeyUp("w"))
        {
            randomSound.Stop();
        }
    }
}

