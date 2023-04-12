using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;
    // Start is called before the first frame update

    public GameObject player;
    public GameObject camera;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;

            player.GetComponent<CharacterController>().controlActive = false;
            camera.GetComponent<MouseCamLook>().camActive = false;
        }
    }
        
        
           
    

        public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        player.GetComponent<CharacterController>().controlActive = true;
        camera.GetComponent<MouseCamLook>().camActive = true;
    }

        public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

   
}
