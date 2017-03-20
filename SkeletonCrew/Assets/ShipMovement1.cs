using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement1 : MonoBehaviour {
    public float movementSpeed = 30;
    public float rotationSpeed = 10;
    public float playerInput;
    public GameObject shipRoot;
    private int shipNumber;
    public GameObject navRoom;
    private int playerControlled;
    private Vector2 velocity;
    private Vector2 currentVector;
    private Vector2 prevVector;

    float currentY;
    float currentX;
    float degggrees;
    float rotationDirection;

    // Use this for initialization
    void Start () {
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        currentVector = GetComponent<Rigidbody2D>().velocity.normalized;
        currentX = currentVector.x;
        currentY = currentVector.y;
        degggrees = Mathf.Asin(currentX);
    }
	
	// Update is called once per frame
	void Update () {
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
     
        if (playerControlled != 0)
        {
            velocity = new Vector2(Input.GetAxis("LeftHorizontalController" + ((shipNumber * 2) - 2 + playerControlled)), Input.GetAxis("LeftVerticalController" + ((shipNumber * 2) - 2 + playerControlled)));
            float velocityX = velocity.normalized.x;
            float velocityY = velocity.normalized.y;
            float velocityDegrees = Mathf.Asin(velocityX);

            if (!(degggrees >= (velocityDegrees - 1) && degggrees <= (velocityDegrees + 1)))
            {
                currentX = currentVector.x;
                currentY = currentVector.y;
                if (Mathf.Max(velocityDegrees, degggrees) - Mathf.Min(velocityDegrees, degggrees) >= 180.0f * Mathf.Deg2Rad)
                {
                    rotationDirection = 1;
                }
                else
                {
                    rotationDirection = -1;
                }
                degggrees = ((Mathf.Asin(currentX)) + (0.0005f * rotationDirection));
                
            }
            currentVector = new Vector2(Mathf.Cos(degggrees), Mathf.Sin(degggrees));

            GetComponent<Rigidbody2D>().velocity = (currentVector * (((movementSpeed * Input.GetAxis("LeftTriggerController" + ((shipNumber * 2) - 2 + playerControlled))) + 0.001f)));



            if (!currentVector.Equals(Vector2.zero))
            {
                prevVector = GetComponent<Rigidbody2D>().velocity;
            }
            transform.right = prevVector;
        }
    }
}
