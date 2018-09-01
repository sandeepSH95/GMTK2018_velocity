﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text counter_text;
    public float milliseconds, seconds, minutes;
    private bool timerRunning;

    //public float startTime, elapsedtime;

	// Use this for initialization
	void Start () {
        counter_text = GetComponent<Text>() as Text;
        timerRunning = true;
	}
	
	// Update is called once per frame
	void Update () {

        minutes = (int)(Time.time / 60f);
        seconds = (int)(Time.time % 60f);
        milliseconds = (int)(Time.time * 1000 - seconds * 1000);

        if (timerRunning)
        {
            counter_text.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00").Substring(0,2);
        }
	}

    public void stopTimer()
    {
        timerRunning = false;
    }

    public void resumeContTimer()
    {
        timerRunning = true;
    }
}
