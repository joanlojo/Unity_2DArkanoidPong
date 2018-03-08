using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectarGol : MonoBehaviour {
    public int gol;
    public Text text;
    public GameObject ball;

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
            //Destroy(other);
            Instantiate(ball, new Vector3(0, 4, 0), Quaternion.identity);
        }
    }
}
