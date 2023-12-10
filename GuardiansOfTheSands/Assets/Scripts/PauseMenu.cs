using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))  
        { 
            ChangePauseMenu();
        }
    }

    public void ChangePauseMenu()
    {
        if (pauseMenu.activeSelf) // si on appuie sur echap alors que les settings sont actifs, retire les settings
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

        }
        else // si on appuie sur echap, alors le jeu se met en pause et le menu des paramêtres se lance.
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }
    public void restartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void returnMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
