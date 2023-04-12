using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WeaponAttack : MonoBehaviour
{
    [SerializeField] private Image healthBar;

    private float maxHealth = 300f;
    private float currentHealth;

    private void Start()
    {
        if (!GetComponent<BoxCollider>().isTrigger)
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AIFinalBoss")
        {
            currentHealth -= 5f;
            UpdateHealthBar();
        }
    }

    private void UpdateHealthBar()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
    }
}
 
