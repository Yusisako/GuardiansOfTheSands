using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class SoundController : MonoBehaviour
{
    private Scrollbar scrollbar;

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        scrollbar = GetComponent<Scrollbar>();
        scrollbar.value = AudioListener.volume;
    }

    public void ModifySoundVolume()
    {
        AudioListener.volume = scrollbar.value;
    }
}
