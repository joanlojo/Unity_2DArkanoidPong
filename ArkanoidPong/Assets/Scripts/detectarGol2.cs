using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            if(gol2 == 9)
            {
                SceneManager.LoadScene("main");
            }
            else
            {
                gol2 += 1;
                text2.text = gol2.ToString();
                Instantiate(ball, new Vector3(10, 10.6f, 0), Quaternion.identity);
            }
           
        }
    }
}
