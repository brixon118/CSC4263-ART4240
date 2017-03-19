using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayerControls : MonoBehaviour {
    public int playerControlled = 0;
    private PlayersController playerController;

    // Use this for initialization
    void Start () {
		
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
            if (Input.GetButtonUp("Jump"))
            {
                playerController = other.gameObject.GetComponent<PlayersController>();
                if (playerControlled == 0)
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
