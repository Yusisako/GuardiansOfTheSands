using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NotAMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void Play()
    {
        SceneManager.LoadScene("MarioClone");
    }

    public void PlayLevel(int level)
    {
        SceneManager.LoadScene("Level" + level);
    } 

    public void Quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
