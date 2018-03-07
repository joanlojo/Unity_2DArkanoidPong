using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectarGol : MonoBehaviour {
    public int gol;
    public Text text;
    private void Start()
    {
        gol = 0;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "pelota")
        {
            gol += 1;
            text.text = gol.ToString();
            other.transform.position = new Vector3(0, 4, -4);
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(1,1,1);
        }
    }
}
