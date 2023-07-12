using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimation : MonoBehaviour
{
    public Animation anim;
    public GameObject MainCamera;
    public GameObject CutsceneCamera;
    
    // Start is called before the first frame update
    void Start()
    {
       // CutsceneCamera.SetActive(false);
      //  MainCamera.SetActive(true);

        CutsceneCamera.SetActive(true);
        MainCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
          CutsceneCamera.SetActive(false);
          MainCamera.SetActive(true);
        }
        
        // if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Final_Level_Opening_Cutscene"))
        {
           // myAnimation.gameObject.GetComponent<Animator>().enabled = false;
        }
    }
}
