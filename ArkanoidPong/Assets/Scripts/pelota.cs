using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour
{

    public int speed = 20;
    // Use this for initialization
    void Start()
    {
        if (Random.value < 0.5f)
            speed = -speed;
        else
            speed = +speed;

        gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
  
        if (col.gameObject.name == "barra")
        {
            float sign = transform.position.x - col.transform.position.x;
            GetComponent<Rigidbody2D>().velocity = new Vector2(sign * Mathf.Abs(speed), Mathf.Abs(speed));
        }

  
        if (col.gameObject.name == "barra2")
        {
            float sign = transform.position.x - col.transform.position.x;
            GetComponent<Rigidbody2D>().velocity = new Vector2(sign * Mathf.Abs(speed), Mathf.Abs(speed));
        }
    }
}
