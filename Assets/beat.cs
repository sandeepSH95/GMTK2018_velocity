using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beat : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(beating());
;	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator beating()
    {
        while (true)
        {
            transform.localScale += new Vector3(0.1f, 0.1f);
            yield return new WaitForSeconds(0.2f);
            transform.localScale -= new Vector3(0.1f, 0.1f);
            yield return new WaitForSeconds(0.25f);
        }
    }
}
