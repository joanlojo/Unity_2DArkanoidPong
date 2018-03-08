using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour {

    public int speed = 20;
	// Use this for initialization
	void Start () {
        if (Random.value < 0.5f)
            speed = -speed;
        else
            speed = +speed;

        gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
