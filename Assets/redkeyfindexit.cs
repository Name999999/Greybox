using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redkeyfindexit : MonoBehaviour
{
    public GameObject Key3;
    public GameObject EscapeText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            EscapeText.SetActive(true);
        }
    }
}
