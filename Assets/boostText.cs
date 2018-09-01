using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boostText : MonoBehaviour {

    public Text boostFactorText;
    public movement playerMovement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        boostFactorText.text = "Boost Factor: " + (playerMovement.speed - 5.0f).ToString("F2");
	}
}
