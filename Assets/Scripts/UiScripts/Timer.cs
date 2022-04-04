using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{
    int minutes;
    float seconds;
    
    [SerializeField] TextMeshProUGUI timerText;

    private void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        CountTime();
        SetTime();
        SendTimeToGameManager();

    }   

    void SetTime()
    {
        if (seconds < 10)
        {
            timerText.text = minutes + ":0" + (int)seconds;
        }
        else
        {
            timerText.text = minutes + ":" + (int)seconds;
        }
        
    }

    void CountTime()
    {
        seconds += Time.deltaTime;

        if(seconds >= 60)
        {
            minutes++;
            seconds = 0;
        }
        
    }
    void SendTimeToGameManager()
    {
        GameManager.minutes = minutes;
    }
}
