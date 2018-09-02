using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishLine : MonoBehaviour {

    public Timer timer;
    public GameObject FinishCanvas;
    bool isFinished;


    // Use this for initialization
    void Start () {
        isFinished = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isFinished)
        {
            FinishCanvas.SetActive(true);
        } else
        {
            FinishCanvas.SetActive(false);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            timer.stopTimer();
            Debug.Log("Finish Line Reached!");
        }

    }


}
