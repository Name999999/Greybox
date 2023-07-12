using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{
    public GameObject Key1;
    public GameObject Key2;
    public GameObject Key3;

    [SerializeField] SwitchBehaviour _switchBehaviour;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Key1.SetActive(true);
            _switchBehaviour.DoorLockedStatus();
            Destroy(gameObject);

        }
    }
}
