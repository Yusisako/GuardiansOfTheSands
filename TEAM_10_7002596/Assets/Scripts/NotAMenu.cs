using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NotAMenu : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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

    public void PlayOneShot(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
