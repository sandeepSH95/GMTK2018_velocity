using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour {
    public float speed;
    public float turn_speed;
    public Rigidbody2D rb2d;
    public Text velocityText, velocityText2;
    private float realTime;
    private float tempTime;
    private float readTime;

    public bool isBoosting;

    public float rigidVelocity;

    private float moveHorizontal, moveVertical;

    // Use this for initialization
    void Start () {
        rigidVelocity = 0.0f;
        velocityText.text = "0.0km/h";
        velocityText2.text = "0.0km/h";
        isBoosting = false;
        //StartCoroutine(boostFactorLeak());
        realTime = 0.0f;
        tempTime = 0.0f;
        readTime = 0.0f;
}
	
	// Update is called once per frame
	void Update () {

        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, 1.0f);
        rb2d.AddForce(movement * speed);

        rigidVelocity = rb2d.velocity.magnitude;
        velocityText.text = (rigidVelocity * 10).ToString("F1") + " km/h";
        velocityText2.text = velocityText.text;
        Debug.Log(Time.time);
        realTime = Time.time;
        readTime = realTime - tempTime;

        if (readTime > 0.5f)
        {
            if (speed > 5.0f)
            {
                if (speed >= 5.5f)
                {
                    speed -= 0.2f;
                }
                if (speed < 5.5f)
                {
                    speed = 5.0f;
                }

            }
            readTime = 0.0f;
            tempTime = Time.time;
            Debug.Log("LEAKED BOOST");
        }
    }

    IEnumerator boostFactorLeak()
    {
        while (true)
        {
            if (speed > 5.0f)
            {
                if (speed >= 5.1f)
                {
                    yield return new WaitForSeconds(2.0f);
                    speed -= 0.1f;
                } else
                {
                    yield return new WaitForSeconds(2.0f);
                    speed = 5.0f;
                }

            }
        }
    }
    


}
