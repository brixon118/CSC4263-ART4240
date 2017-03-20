using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeGun : MonoBehaviour {

    HingeJoint2D[] largeHingeJoint = new HingeJoint2D[0];
    JointMotor2D largeJointMotor;

    // Use this for initialization
    void Start()
    {
        largeHingeJoint = gameObject.GetComponents<HingeJoint2D>();
        largeJointMotor = largeHingeJoint[0].motor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            largeJointMotor.motorSpeed = -35;
        }
        else if (Input.GetKey(KeyCode.H))
        {
            largeJointMotor.motorSpeed = 35;
        }
        else
        {
            largeJointMotor.motorSpeed = 0;
        }
        largeHingeJoint[0].motor = largeJointMotor;
    }
}
