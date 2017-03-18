using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsBehavior : MonoBehaviour {
    public float maxHealth = 100;
    public float health = 100;
    public float maxWaterLevel = 100;
    public float waterLevel = 0;
    public int playerControlled = 0;
    private PlayersController playerController;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        

    }


    void OnTriggerStay2D(Collider2D other) {
        health--;
        if( other.CompareTag("PlayerCharacter"))
        {
            if (Input.GetButtonUp("Jump"))
            {
                playerController = other.gameObject.GetComponent<PlayersController>();
                if(playerControlled == 0)
                {
                    playerControlled = playerController.playerNumber;
                    playerController.switchControlled();
                }
                else if (playerControlled == playerController.playerNumber)
                {
                    playerControlled = 0;
                    playerController.switchControlled();
                }
            }
        }
    }

}
