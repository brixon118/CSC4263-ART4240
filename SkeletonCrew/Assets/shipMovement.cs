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
