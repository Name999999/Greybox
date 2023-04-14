using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingBetweenWeaponsNoHand : MonoBehaviour
{
    public GameObject HandIdol;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            HandIdol.SetActive(false);
        }

        if (Input.GetKey("2"))
        {
            HandIdol.SetActive(false);
        }
    }
}
