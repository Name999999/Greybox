using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingBetweenWeaponsColliders : MonoBehaviour
{
    public Collider HandWithMakeShiftArrow;
    public Collider Cylinder;
    public Collider Cylinder1;
    public Collider Cylinder2;
    public Collider Cylinder3;

    // Start is called before the first frame update
    void Start()
    {
        HandWithMakeShiftArrow = GetComponent<Collider>();
        Cylinder = GetComponent<Collider>();
        Cylinder1 = GetComponent<Collider>();
        Cylinder2 = GetComponent<Collider>();
        Cylinder3 = GetComponent<Collider>();
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
