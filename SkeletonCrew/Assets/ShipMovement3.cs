using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement3 : MonoBehaviour {

    public GameObject navRoom;
    private int playerControlled;
    public float movementSpeed = 30;
    public float rotationSpeed = 10;
    float currentY;
    float currentX;
    float degggrees;
    float rotationDirection = 1;
    private Vector2 currentVector;
    public GameObject shipRoot;
    private int shipNumber;
    private Vector2 velocityGoal;
    private Vector2 prevVector;

    // Use this for initialization
    void Start () {
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        currentVector = GetComponent<Rigidbody2D>().velocity;
        currentX = currentVector.x;
        currentY = currentVector.y;
        degggrees = Mathf.Atan2(currentVector.y, currentVector.x);
    }
	
	// Update is called once per frame
	void Update () {
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;


        if (playerControlled != 0)
        {
            velocityGoal = new Vector2(Input.GetAxis("LeftHorizontalController" + ((shipNumber * 3) - 2 + playerControlled)), Input.GetAxis("LeftVerticalController" + ((shipNumber * 3) - 2 + playerControlled)));
            currentVector = GetComponent<Rigidbody2D>().velocity;
            degggrees = Mathf.Atan2(currentVector.x, currentVector.y);
            degggrees += 0.01f;
            //currentVector = new Vector2(Mathf.Sin(degggrees), Mathf.Cos(degggrees));
            currentVector = Quaternion.AngleAxis(30.0f, Vector3.forward) * currentVector;
            GetComponent<Rigidbody2D>().velocity = (currentVector * ((movementSpeed * Input.GetAxis("LeftTriggerController" + ((shipNumber * 3) - 2 + playerControlled))) + 0.0001f));
            if (!velocityGoal.Equals(Vector2.zero))
            {
                prevVector = GetComponent<Rigidbody2D>().velocity.normalized;
            }
        }
        transform.right = prevVector;






    }
}
