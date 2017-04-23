using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapStorage : MonoBehaviour {
    public int currentScrap;
    public bool player1 = true;
	// Use this for initialization
	void Start () {
        if (player1)
        {
             currentScrap = gameController.playerOneScrap;
        }
        else
        {
            currentScrap = gameController.playerTwoScrap;
        }
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
