using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningAnimation : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject YouWinScreen;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera.SetActive(true);
        YouWinScreen.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            YouWinScreen.SetActive(true);

        }
    }
}
