﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {
    public float movementSpeed = 30;
    public float rotationSpeed = 10;
    public float playerInput;
    public GameObject shipRoot;
    private int shipNumber;
    public GameObject navRoom;
    private int playerControlled;
    private Vector2 velocity;

    // Use this for initialization
    void Start () {
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
    }
	
	// Update is called once per frame
	void Update () {
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        UserInputs();
        GetComponent<Rigidbody2D>().AddTorque(20);

    }

    void UserInputs()
    {

        if (playerControlled == 1)
        {
            //GetComponent<Transform>().rotation.z 


            velocity = new Vector2(Input.GetAxis("LeftHorizontalController" + ((shipNumber * 2) - 1)), Input.GetAxis("LeftVerticalController" + ((shipNumber * 2) - 1)));
        }

        else if (playerControlled == 2)
        {
            velocity = new Vector2(Input.GetAxis("LeftHorizontalController" + ((shipNumber * 2))), Input.GetAxis("LeftVerticalController" + ((shipNumber * 2))));
        }

        playerInput = playerControlled;
    }

}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMovement : MonoBehaviour {

	public float movementSpeed = 30;
	public float rotationSpeed = 10;
	public float playerInput;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		UserInputs ();
	}

	void UserInputs(){
		
		if (playerInput == 1) {
			transform.Translate (Input.GetAxis ("360_LeftThumbStick") * movementSpeed, 0, 0);
			transform.Rotate(0, Input.GetAxis("360_LeftThumbStick") * rotationSpeed, 0);
		}

		if (playerInput == 2) {
			transform.Translate (0, 0, Input.GetAxis ("360_RightThumbStick") * movementSpeed);
			transform.Rotate(0, Input.GetAxis("360_RightThumbStick") * rotationSpeed, 0);
		}

		playerInput = playerControlled;
	}

} 
 */
