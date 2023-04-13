using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WeaponAttack : MonoBehaviour
{
    [SerializeField] private Image healthBar;

    private float maxHealth = 300f;
    public float currentHealth;
    public GameObject YouWinCanvas;
    public GameObject GameGUI;

    private void Start()
    {
        if (!GetComponent<BoxCollider>().isTrigger)
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }
        currentHealth = maxHealth;
        UpdateHealthBarEnemy();
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            YouWinCanvas.SetActive(true);
            Time.timeScale = 0f;
            GameGUI.SetActive(false);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            currentHealth -= 5f;
            UpdateHealthBarEnemy();
        }
    }

    private void UpdateHealthBarEnemy()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
    }
}
 
