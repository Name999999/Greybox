using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingHands1 : MonoBehaviour
{
    [SerializeField] private GameObject Hand1; // Default
    [SerializeField] private GameObject Hand2; // Metal Pole
    [SerializeField] private GameObject Hand3; // Bow

    public enum Hands
    {
        Empty,
        Pole,
        Bow
    }
    public Hands selectedItem = Hands.Empty;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (selectedItem == Hands.Pole)
            {
                selectedItem = Hands.Empty;
            }
            else if (selectedItem != Hands.Pole)
            {
                selectedItem = Hands.Pole;
            }
            ChangeSelectedItem(selectedItem);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (selectedItem == Hands.Bow)
            {
                selectedItem = Hands.Empty;
            }
            else if (selectedItem != Hands.Bow)
            {
                selectedItem = Hands.Bow;
            }
            ChangeSelectedItem(selectedItem);
        }
    }

    private void ChangeSelectedItem(Hands itemToSelect)
    {
        switch(itemToSelect)
        {
            case (Hands.Empty):
                Hand1.SetActive(true);
                Hand2.SetActive(false);
                Hand3.SetActive(false);
                break;
            case (Hands.Pole):
                Hand1.SetActive(false);
                Hand2.SetActive(true);
                Hand3.SetActive(false);
                break;
            case (Hands.Bow):
                Hand1.SetActive(false);
                Hand2.SetActive(false);
                Hand3.SetActive(true);
                break;
        }
    }
}
