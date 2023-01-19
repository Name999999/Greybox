using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    // VARS
    public Canvas inventoryHUD;
    public GameObject invManager;

    public bool hasItem1 = false; // Bools for seeing if an item is owned
    public bool hasItem2 = false;
    public bool hasItem3 = false;
    public bool hasItem4 = false;
    public bool hasItem5 = false;
    public bool hasItem6 = false;
    public bool hasItem7 = false;
    public bool hasItem8 = false;
    public bool hasItem9 = false;
    public bool hasItem10 = false;

    public int itemCollectionIndex;

    public Color unselectedColour;
    public Color selectedColour;

    public Image[] borderImages;
    public Image[] invImages;

    public int lastSlotActivated;
    public int selectedItem;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateUISlots();
        lastSlotActivated = -1;
        selectedItem = -1;
        itemCollectionIndex = -1;
    }

    // Update is called once per frame
    void Update()
    {
        // List of inventory keys - Currently just changes what is highlighted and updated an int called 'selectedItem' which you will need to associate with objects.
        if (Input.GetKeyDown("1") && hasItem1)
        {
            UpdateUI(0, selectedItem);
            selectedItem = 0;
        }
        if (Input.GetKeyDown("2") && hasItem2)
        {
            UpdateUI(1, selectedItem);
            selectedItem = 1;
        }
        if (Input.GetKeyDown("3") && hasItem3)
        {
            UpdateUI(2, selectedItem);
            selectedItem = 2;
        }
        if (Input.GetKeyDown("4") && hasItem4)
        {
            UpdateUI(3, selectedItem);
            selectedItem = 3;
        }
        if (Input.GetKeyDown("5") && hasItem5)
        {
            UpdateUI(4, selectedItem);
            selectedItem = 4;
        }
        if (Input.GetKeyDown("6") && hasItem6)
        {
            UpdateUI(5, selectedItem);
            selectedItem = 5;
        }
        if (Input.GetKeyDown("7") && hasItem7)
        {
            UpdateUI(6, selectedItem);
            selectedItem = 6;
        }
        if (Input.GetKeyDown("8") && hasItem8)
        {
            UpdateUI(7, selectedItem);
            selectedItem = 7;
        }
        if (Input.GetKeyDown("9") && hasItem9)
        {
            UpdateUI(8, selectedItem);
            selectedItem = 8;
        }
        if (Input.GetKeyDown("0") && hasItem10)
        {
            UpdateUI(9, selectedItem);
            selectedItem = 9;
        }
    }

    public void GetsItem(int itemIndex)
    {
        itemCollectionIndex = itemIndex;
        if (itemCollectionIndex == 0)
        {
            hasItem1 = true;
            invManager.GetComponent<Inventory>().GetItemUI(0);

        }
        if (itemCollectionIndex == 1)
        {
            hasItem2 = true;
            invManager.GetComponent<Inventory>().GetItemUI(1);

        }
        if (itemCollectionIndex == 2)
        {
            invManager.GetComponent<Inventory>().GetItemUI(2);
            hasItem3 = true;
        }
        if (itemCollectionIndex == 3)
        {
            invManager.GetComponent<Inventory>().GetItemUI(3);
            hasItem4 = true;
        }
        if (itemCollectionIndex == 4)
        {
            invManager.GetComponent<Inventory>().GetItemUI(4);
            hasItem5 = true;
        }
        if (itemCollectionIndex == 5)
        {
            invManager.GetComponent<Inventory>().GetItemUI(5);
            hasItem6 = true;
        }
        if (itemCollectionIndex == 6)
        {
            invManager.GetComponent<Inventory>().GetItemUI(6);
            hasItem7 = true;
        }
        if (itemCollectionIndex == 7)
        {
            invManager.GetComponent<Inventory>().GetItemUI(7);
            hasItem8 = true;
        }
        if (itemCollectionIndex == 8)
        {
            invManager.GetComponent<Inventory>().GetItemUI(8);
            hasItem9 = true;
        }
        if (itemCollectionIndex == 9)
        {
            invManager.GetComponent<Inventory>().GetItemUI(9);
            hasItem10 = true;
        }


    }

    void DeactivateUISlots()
    {
        for (int i = 0; i < 9; i++)
        {
            invImages[i].gameObject.SetActive(false);
        }
    }
    
    public void GetItemUI(int slot)
    {
        invImages[slot].gameObject.SetActive(true);
        Debug.Log("Item " + slot + " acquired");
    }


    public void UpdateUI(int slot, int oldSlot)
    {
        borderImages[slot].GetComponent<Image>().color = selectedColour;
        if (selectedItem > -1)
        {
            borderImages[oldSlot].GetComponent<Image>().color = unselectedColour;
        }

        selectedItem = slot;


    }
}
