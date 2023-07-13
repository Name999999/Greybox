using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private Image healthBar;

    private float maxHealth = 3000f;
    public float currentHealth;
    public GameObject YouWinCanvas;
    public GameObject GameGUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("BossCutsceneScene2");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapons"))
        {
            currentHealth -= 5f;
            UpdateHealthBarEnemy();
        }
    }

    public void UpdateHealthBarEnemy()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
    }
}
