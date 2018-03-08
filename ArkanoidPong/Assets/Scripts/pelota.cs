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

    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                float racketWidth)
    {
        return (racketPos.x - ballPos.x) / racketWidth;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
  
        if (col.gameObject.name == "barra")
        {
          
            float x = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.x);

            Vector2 dir = new Vector2(x, -1).normalized;

         
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

  
        if (col.gameObject.name == "barra2")
        {
      
            float x = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.x);

            Vector2 dir = new Vector2(x, -1).normalized;

            
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }
}
