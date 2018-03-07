using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "pelota")
            Destroy(gameObject);

    }
}
