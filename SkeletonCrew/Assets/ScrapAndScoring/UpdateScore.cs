using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour {
    public static int score;
    public bool player1;
    // Use this for initialization
    void Start () {
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (player1)
        {
            score = gameController.playerOneScrap;
        }
        else
        {
            score = gameController.playerTwoScrap;
        }
        GetComponent<Text>().text = "Scrap: " + score;
	}
}
