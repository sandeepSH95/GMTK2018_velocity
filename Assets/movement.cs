using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour {
    public float speed;
    public float turn_speed;
    public Rigidbody2D rb2d;
    public Text velocityText;

    public float rigidVelocity;

    private float moveHorizontal, moveVertical;

    // Use this for initialization
    void Start () {
        rigidVelocity = 0.0f;
        velocityText.text = "0.0km/h";
	}
	
	// Update is called once per frame
	void Update () {

        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, 1.0f);
        rb2d.AddForce(movement * speed);

        rigidVelocity = rb2d.velocity.magnitude;
        velocityText.text = (rigidVelocity * 100).ToString("F1") + " km/h";
    }

}
