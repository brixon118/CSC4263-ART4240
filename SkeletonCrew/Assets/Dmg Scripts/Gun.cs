using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    HingeJoint2D[] hingeJoint = new HingeJoint2D[0];
    JointMotor2D jointMotor;

    private int playerControlled;
    private int shipNumber;
    public GameObject shipRoot;
    public GameObject navRoom;
    public float horizontalControl;

	// Use this for initialization
	void Start () {
        hingeJoint = gameObject.GetComponents<HingeJoint2D>();
        jointMotor = hingeJoint[0].motor;
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
	}
	
	// Update is called once per frame
	void Update () {
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        if (playerControlled != 0)
        {
            horizontalControl = Input.GetAxisRaw("LeftHorizontalController" + ((shipNumber * 2) - 2 + playerControlled));
            if (horizontalControl == -1)
            {
                jointMotor.motorSpeed = -35;
            }
            else if (horizontalControl == 1)
            {
                jointMotor.motorSpeed = 35;
            }
            else
            {
                jointMotor.motorSpeed = 0;
            }
            hingeJoint[0].motor = jointMotor;
        }
    }
}
