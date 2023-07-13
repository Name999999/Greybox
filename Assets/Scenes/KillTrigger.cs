using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillTrigger : MonoBehaviour
{
    public Animator animator;
    public string deathAnimationTrigger;
    public string retrySceneName;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("I should be dying now");

            // Play death animation
            animator.SetTrigger(deathAnimationTrigger);

            // Load retry scene after a delay
            Invoke("LoadRetryScene", 0.25f);
        }
    }

    private void LoadRetryScene()
    {
        SceneManager.LoadScene(retrySceneName);
    }
}
