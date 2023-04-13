using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class AIFunctionFinalLevel : MonoBehaviour
{
    [SerializeField] private Image healthBar;

    private float maxHealth = 300f;
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
            YouLoseCanvas.SetActive(true);
            Time.timeScale = 0f;
            GameGUI.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            currentHealth -= 5f;
            UpdateHealthBarPlayer();
        }
    }

    private void UpdateHealthBarPlayer()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
    }
}
