using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch_Complete : MonoBehaviour
{
    public Light lightToSwitch;

    public GameObject LevelManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //when the player is inside the trigger
    private void OnTriggerEnter(Collider other)                     
    {
                if (lightToSwitch.enabled == false) //off
                {
                    lightToSwitch.enabled = true;
                }
                //else don't enable the light switch
                else
                {
                    lightToSwitch.enabled = false;
                }
            
        
    }
}
