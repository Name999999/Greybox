using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningAnimationScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animation>()["FirstPersonPlayer_Cutscene_Player"].wrapMode = WrapMode.Once; 
        GetComponent<Animation>().Play("FirstPersonPlayer_Cutscene_Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
