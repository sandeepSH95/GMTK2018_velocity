using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerEnter : MonoBehaviour {

    public CircleCollider2D playerCollider;
    public movement player;

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
        }
    }
}
