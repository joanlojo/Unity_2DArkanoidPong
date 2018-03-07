using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectarGol2 : MonoBehaviour {
    public int gol2;
    public Text text2;
    private void Start()
    {
        gol2 = 0;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "pelota")
        {
            gol2 += 1;
            text2.text = gol2.ToString();
            other.transform.position = new Vector3(0, 4, -4);
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(1, 1, 1);
        }
    }
}
