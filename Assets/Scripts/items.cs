using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class items : MonoBehaviour {

    public Transform invKey;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            invKey.GetComponent<Transform>().position = new Vector3(0, 4.7f,10);
            moveWalls.haveCoin = "y";
            Destroy(gameObject);
        }
    }
}
