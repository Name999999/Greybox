using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingBetweenWeaponsBackup : MonoBehaviour
{
    public GameObject Pole;
    public GameObject MakeShiftArrow;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            Pole.SetActive(false);
            MakeShiftArrow.SetActive(true);
        }

        if (Input.GetKey("2"))
        {
            Pole.SetActive(true);
            MakeShiftArrow.SetActive(false);
        }
    }
}
