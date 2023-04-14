using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingHands2 : MonoBehaviour
{
    public GameObject HandWithArrow;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            HandWithArrow.SetActive(false);
        }

        if (Input.GetKey("2")) 
        {
            HandWithArrow.SetActive(true);

        }
    
    }
}
