using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class textDifficulty : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        moveWalls.gameDif = gameObject.name;
        Debug.Log(moveWalls.gameDif);
        SceneManager.LoadScene("Maze Runner");
    }
}
