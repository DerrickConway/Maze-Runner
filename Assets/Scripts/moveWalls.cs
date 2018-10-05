using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWalls : MonoBehaviour {
    /*public float speed;

    private Rigidbody2D rb2d;

     void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
    }*/


    public Transform heroObj;
    public static string haveCoin = "n";
    public static string gameDif = "none";
	
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update () {
		if (Input.GetKey("w"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -3);
           // heroObj.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else

        if (Input.GetKey("s"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 3);
          //  heroObj.transform.eulerAngles = new Vector3(0, 0, 180);
        }

        else

        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(3, 0);
          //  heroObj.transform.eulerAngles = new Vector3(0, 0, 90);
           // transform.localScale = new Vector2(1f, 1f);
        }

        else

        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);
           // heroObj.transform.eulerAngles = new Vector3(0, 0, -90);
           // transform.localScale = new Vector2(-1f, 1f);
        }

        else

        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

    }
}
