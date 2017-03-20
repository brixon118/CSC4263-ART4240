using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftGun : MonoBehaviour
{

    HingeJoint2D[] lhingeJoint = new HingeJoint2D[0];
    JointMotor2D ljointMotor;

    // Use this for initialization
    void Start()
    {
        lhingeJoint = gameObject.GetComponents<HingeJoint2D>();
        ljointMotor = lhingeJoint[0].motor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ljointMotor.motorSpeed = -35;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ljointMotor.motorSpeed = 35;
        }
        else
        {
            ljointMotor.motorSpeed = 0;
        }
        lhingeJoint[0].motor = ljointMotor;
    }
}