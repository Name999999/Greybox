using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class AIFunctionFinalLevel : MonoBehaviour
{
    [SerializeField] private Image healthBar;

    public float maxHealth = 500f;
    private float currentHealth;
    public GameObject YouLoseCanvas;
    public GameObject GameGUI;


    private void Start()
    {
        if (!GetComponent<BoxCollider>().isTrigger)
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }
        currentHealth = maxHealth;
        UpdateHealthBarPlayer();
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("BossCutsceneScene1");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            currentHealth -= 50;
            UpdateHealthBarPlayer();
        }
    }

    private void UpdateHealthBarPlayer()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
    }
}
