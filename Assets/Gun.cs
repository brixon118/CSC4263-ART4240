using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    HingeJoint2D[] hingeJoint = new HingeJoint2D[0];
    JointMotor2D jointMotor;

	// Use this for initialization
	void Start () {
        hingeJoint = gameObject.GetComponents<HingeJoint2D>();
        jointMotor = hingeJoint[0].motor;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.J))
        {
            jointMotor.motorSpeed = -35;
        }
        else if (Input.GetKey(KeyCode.L))
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
