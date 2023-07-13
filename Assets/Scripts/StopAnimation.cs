using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopAnimation : MonoBehaviour
{
    public Animation anim;
    public GameObject MainCamera;
    public GameObject CutsceneCamera;
    public GameObject DyingCamera;
    public GameObject Text;
    

    // Start is called before the first frame update
    void Start()
    {
       // CutsceneCamera.SetActive(false);
      //  MainCamera.SetActive(true);

        CutsceneCamera.SetActive(true);
        MainCamera.SetActive(false);
        Text.SetActive(false);
        Invoke("EnableText", 13f);
        Invoke("DisableText", 23f);
    }

    public void DisableText()
    {
        Text.SetActive(false);
    }
    public void EnableText()
    {
        Text.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
           
                MainCamera.SetActive(false);
                DyingCamera.SetActive(true);
                anim.Play("Dying");
               

        }
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