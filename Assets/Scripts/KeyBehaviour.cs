using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{
    [SerializeField] SwitchBehaviour _switchBehaviour;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _switchBehaviour.DoorLockedStatus();
            Destroy(gameObject);
        }
    }
}
