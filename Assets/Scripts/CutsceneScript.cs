using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneScript : MonoBehaviour
{
    public GameObject EndScreen;


    // Start is called before the first frame update
    void Start()
    {
        EndScreen.SetActive(false);
        Invoke("EnableImage", 5f);
    }

    void EnableImage()
    {
        EndScreen.SetActive(true);
    }

}
