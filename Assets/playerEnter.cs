﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerEnter : MonoBehaviour {

    public CircleCollider2D playerCollider;
    public movement player;
    public Color tempColor;
    public Color boostColor;
    public SpriteRenderer spriteColor;
    public Text leftBoost, rightBoost;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.speed += 0.05f;
            Debug.Log(collision.name);
            spriteColor.color = boostColor;
            leftBoost.color = tempColor;
            rightBoost.color = tempColor;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            spriteColor.color = tempColor;
            leftBoost.color = Color.black;
            rightBoost.color = Color.black;
        }
    }
}
