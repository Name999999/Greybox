using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WeaponAttack : MonoBehaviour
{
    [SerializeField] private Image healthBar;

    private float maxHealth = 5000f;
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
        if (other.CompareTag("Enemy"))
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
 
