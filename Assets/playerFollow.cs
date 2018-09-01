using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerFollow : MonoBehaviour {

    public Transform camTransform;
    public Transform targetTransform;
    public int distance = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        camTransform.position = new Vector3(targetTransform.position.x, targetTransform.position.y, -10.0f);
    }
}
