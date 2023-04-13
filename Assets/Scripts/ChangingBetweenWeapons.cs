using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingBetweenWeapons : MonoBehaviour
{
    public Renderer HandWithMakeShiftArrow;
    public Renderer Cylinder;
    public Renderer Cylinder1;
    public Renderer Cylinder2;
    public Renderer Cylinder3;

    // Start is called before the first frame update
    void Start()
    {
        HandWithMakeShiftArrow = GetComponent<Renderer>();
        Cylinder = GetComponent<Renderer>();
        Cylinder1 = GetComponent<Renderer>();
        Cylinder2 = GetComponent<Renderer>();
        Cylinder3 = GetComponent<Renderer>();
        HandWithMakeShiftArrow.enabled = false;
        Cylinder.enabled = false;
        Cylinder1.enabled = false;
        Cylinder2.enabled = false;
        Cylinder3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            HandWithMakeShiftArrow.enabled = false;
            Cylinder.enabled = false;
            Cylinder1.enabled = false;
            Cylinder2.enabled = false;
            Cylinder3.enabled = false;
        }

        if (Input.GetKey("2"))
        {
            HandWithMakeShiftArrow.enabled = true;
            Cylinder.enabled = true;
            Cylinder1.enabled = true;
            Cylinder2.enabled = true;
            Cylinder3.enabled = true;
        }
    }
}
