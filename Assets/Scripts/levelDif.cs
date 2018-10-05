using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelDif : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
        if (moveWalls.gameDif == "easy")
        {
            Destroy(gameObject);

        }

        if ((moveWalls.gameDif == "medium")  && (gameObject.name == "Coin" || gameObject.name == "Box" || gameObject.name == "Door"))
        {
            Destroy(gameObject);

        }



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
