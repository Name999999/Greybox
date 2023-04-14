using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingHands1 : MonoBehaviour
{
    public GameObject Hand1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            Hand1.SetActive(true);
        }

        if (Input.GetKey("2"))
        {
            Hand1.SetActive(false);
        }
    }
}
