using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapStorage : MonoBehaviour {
    public int currentScrap = 0;
    public bool player1 = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player1)
        {
            gameController.playerOneScrap = currentScrap;
        }
        else
        {
            gameController.playerTwoScrap = currentScrap;
        }
		
	}
}
