using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeItemCollection : MonoBehaviour
{
    public GameObject invManager; // ref to inventory manager

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            invManager.GetComponent<Inventory>().hasItem1 = true;
            invManager.GetComponent<Inventory>().GetItemUI(0);
        }
        if (Input.GetKeyDown("w"))
        {
            invManager.GetComponent<Inventory>().hasItem2 = true;
            invManager.GetComponent<Inventory>().GetItemUI(1);
        }
        if (Input.GetKeyDown("e"))
        {
            invManager.GetComponent<Inventory>().hasItem3 = true;
            invManager.GetComponent<Inventory>().GetItemUI(2);
        }
        if (Input.GetKeyDown("r"))
        {
            invManager.GetComponent<Inventory>().hasItem4 = true;
            invManager.GetComponent<Inventory>().GetItemUI(3);
        }
        if (Input.GetKeyDown("t"))
        {
            invManager.GetComponent<Inventory>().hasItem5 = true;
            invManager.GetComponent<Inventory>().GetItemUI(4);
        }
        if (Input.GetKeyDown("y"))
        {
            invManager.GetComponent<Inventory>().hasItem6 = true;
            invManager.GetComponent<Inventory>().GetItemUI(5);
        }
        if (Input.GetKeyDown("u"))
        {
            invManager.GetComponent<Inventory>().hasItem7 = true;
            invManager.GetComponent<Inventory>().GetItemUI(6);
        }
        if (Input.GetKeyDown("i"))
        {
            invManager.GetComponent<Inventory>().hasItem8 = true;
            invManager.GetComponent<Inventory>().GetItemUI(7);
        }
        if (Input.GetKeyDown("o"))
        {
            invManager.GetComponent<Inventory>().hasItem9 = true;
            invManager.GetComponent<Inventory>().GetItemUI(8);
        }
        if (Input.GetKeyDown("p"))
        {
            invManager.GetComponent<Inventory>().hasItem10 = true;
            invManager.GetComponent<Inventory>().GetItemUI(9);
        }


    }
}
