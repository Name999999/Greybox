using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    // VARS
    public Canvas inventoryHUD;

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

    public Color unselectedColour;
    public Color selectedColour;

    public Image border1; // Image assignment for HUD item borders
    public Image border2;
    public Image border3;
    public Image border4;
    public Image border5;       
    public Image border6;
    public Image border7;
    public Image border8;
    public Image border9;
    public Image border10;

    public Image itemImage1; // Image assignment for actual object sprites
    public Image itemImage2;
    public Image itemImage3;
    public Image itemImage4;
    public Image itemImage5;    
    public Image itemImage6;
    public Image itemImage7;
    public Image itemImage8;
    public Image itemImage9;
    public Image itemImage10;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
