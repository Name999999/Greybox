using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] GameObject _flashlightParent;
    [SerializeField] GameObject _flashlight;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log(_flashlightParent.activeSelf);
            _flashlightParent.SetActive(true);
        }

        if (Input.GetKeyUp("space"))
        {
            Debug.Log(_flashlightParent.activeSelf);
            _flashlightParent.SetActive(false);
        }
    }
}
