using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LosingAnimation : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject YouLoseScreen;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera.SetActive(true);
        YouLoseScreen.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            YouLoseScreen.SetActive(true);

        }

        if (YouLoseScreen && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Boss");
        }
    }
}
