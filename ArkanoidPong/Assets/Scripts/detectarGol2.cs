using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectarGol2 : MonoBehaviour {
    public int gol2;
    public Text text2;
    public GameObject ball;

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
            //Destroy(other);
            Instantiate(ball, new Vector3(0, 4, 0), Quaternion.identity);
        }
    }
}
