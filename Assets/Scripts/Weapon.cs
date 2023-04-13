using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    EnemyHealth EnemyHealthScript;

    private void Start()
    {
        EnemyHealthScript = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<EnemyHealth>();
        
        if (!GetComponent<BoxCollider>().isTrigger)
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyHealthScript.UpdateHealthBarEnemy();
        }
    }

}
