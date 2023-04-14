using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingBetweenWeaponsCollider2 : MonoBehaviour
{
    public Collider HandWithPole;
    public Collider Pole;

    // Start is called before the first frame update
    void Start()
    {
        HandWithPole = GetComponent<Collider>();
        Pole = GetComponent<Collider>();
        HandWithPole.enabled = false;
        Pole.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            HandWithPole.enabled = true;
            Pole.enabled = true;
        }

        if (Input.GetKey("2"))
        {
            HandWithPole.enabled = false;
            Pole.enabled = false;
        }
    }
}
