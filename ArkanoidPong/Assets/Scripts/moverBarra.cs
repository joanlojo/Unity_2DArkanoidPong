using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverBarra : MonoBehaviour {

    public float speed;

    private Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

        rb.velocity = (movement * speed);
    }
}
