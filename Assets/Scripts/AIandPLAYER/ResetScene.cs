using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{

    public Animation anim;

    void Start()
    {
        if (!GetComponent<BoxCollider>().isTrigger)
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }
        anim = GetComponent<Animation>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(waiter());
            IEnumerator waiter()
            {
                anim.Play("Dying");
                yield return new WaitForSeconds(10.0f);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
           
        }
    }
}
