using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
    public AudioClip Quit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("MarioClone");
    }

    public void Rick()
    {
        GetComponent<AudioSource>().PlayOneShot(Quit);
    }
    
    public void doExitGame() 
    {
        Application.Quit();
    }
}
