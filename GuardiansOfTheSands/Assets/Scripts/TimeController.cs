using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    public float limitTime = 100;

    public float leftTime;

    private WinLose winLose;
    // Start is called before the first frame update
    void Start()
    {
        leftTime = limitTime;
        winLose = GetComponent<WinLose>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        leftTime -= Time.deltaTime;
        timeText.text = (int)(leftTime / 60) + ":" + (int)leftTime % 60;
        if (leftTime <= 0)
        {
            GameObject.Find("WinLose").GetComponent<WinLose>().GameOver();
        }
    }
    
}
