using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
    public GameObject winCanvas;
    public GameObject GameOverCanvas;


    public void Win()
    {
        Time.timeScale = 0;
        winCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GameOverCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    
}
