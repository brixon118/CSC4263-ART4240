using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayerControls : MonoBehaviour {
    public int playerControlled = 0;
    private PlayersController playerController;
    public GameObject shipRoot;
    public Sprite ssssprite;
    public Sprite originalssssprite;
    private int shipNumber;
    // Use this for initialization
    void Start () {
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
        originalssssprite = GetComponent<SpriteRenderer>().sprite;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        //health--;

        //Switching player control
        if (other.CompareTag("PlayerCharacter"))
        {
            if (Input.GetButtonDown("LeftBumperController" + ((shipNumber * 3) - 2 + other.GetComponent<PlayersController>().playerNumber)))
            {
                playerController = other.gameObject.GetComponent<PlayersController>();
                if (playerControlled == 0)
                {
                    playerControlled = playerController.playerNumber;
                    playerController.switchControlled();
                    //switch
                    GetComponent<SpriteRenderer>().sprite= ssssprite;
                    
                }
                else if (playerControlled == playerController.playerNumber)
                {
                    playerControlled = 0;
                    playerController.switchControlled();
                    //back
                    GetComponent<SpriteRenderer>().sprite = originalssssprite;
                }
            }
        }
    }
}
