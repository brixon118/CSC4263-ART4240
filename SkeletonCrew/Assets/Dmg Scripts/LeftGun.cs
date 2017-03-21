using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftGun : MonoBehaviour
{

    HingeJoint2D[] lhingeJoint = new HingeJoint2D[0];
    JointMotor2D ljointMotor;

    private int playerControlled;
    private int shipNumber;
    public GameObject shipRoot;
    public GameObject navRoom;
    public float horizontalControl;

    // Use this for initialization
    void Start()
    {
        lhingeJoint = gameObject.GetComponents<HingeJoint2D>();
        ljointMotor = lhingeJoint[0].motor;
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
    }

    // Update is called once per frame
    void Update()
    {
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        if (playerControlled != 0)
        {
            horizontalControl = Input.GetAxisRaw("LeftHorizontalController" + ((shipNumber * 2) - 2 + playerControlled));
            if (horizontalControl == -1)
            {
                ljointMotor.motorSpeed = -35;
            }
            else if (horizontalControl == 1)
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
}