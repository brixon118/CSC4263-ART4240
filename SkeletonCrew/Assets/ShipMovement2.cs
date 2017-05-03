using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement2 : MonoBehaviour {
    public float movementSpeed = 30;
    public float rotationSpeed = 10;
    public float playerInput;
    public GameObject shipRoot;
    private int shipNumber;
    public GameObject navRoom;
    private int playerControlled;
    private Vector2 velocity;
    private Vector2 prevVector;
    public float degrees;
    Vector2 currentVector;
    Vector2 newVector;
    float currentX;
    float currentY;
    public bool switchDirection = true;
    public float inputDegree;

    // Use this for initialization
    void Start()
    {
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        currentVector = GetComponent<Rigidbody2D>().velocity;
        currentX = currentVector.normalized.x;

        currentY = currentVector.normalized.y;
        degrees = (Mathf.Atan2(currentX, currentY)) + 0.5f;

        transform.up = currentVector;
    }

    // Update is called once per frame
    void Update()
    {
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        /*//UserInputs();
        //GetComponent<Rigidbody2D>().AddTorque(200000);
        Vector2 currentVector = GetComponent<Rigidbody2D>().velocity.normalized;
        float currentX = currentVector.x;
        float currentY = currentVector.y;
        float degggrees = (Mathf.Atan2(currentY, currentX) + 0.01f) * Mathf.Rad2Deg;
        //velocity = new Vector2(Mathf.Cos(degggrees) * Mathf.Rad2Deg, Mathf.Sin(degggrees) * Mathf.Rad2Deg);
        //GetComponent<Rigidbody2D>().velocity = velocity * 0.00001f;
        //transform.up = velocity.normalized;
        Vector3 newVector = new Vector3(0,0,degggrees);
        GetComponent<Transform>().Rotate(newVector);
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Transform>().position.x - emptyTip.GetComponent<Transform>().position.x, GetComponent<Transform>().position.y - emptyTip.GetComponent<Transform>().position.y);
        */

        if (playerControlled != 0)
        {
            velocity = new Vector2(Input.GetAxis("LeftHorizontalController" + ((shipNumber * 2) - 2 + playerControlled)), Input.GetAxis("LeftVerticalController" + ((shipNumber * 2) - 2 + playerControlled)));
            if (!velocity.Equals(Vector2.zero))
            {
                inputDegree = Mathf.Atan2(velocity.normalized.x, velocity.normalized.y) * Mathf.Rad2Deg;
                float rotationDirection = -1;
                if ((Mathf.Max(inputDegree, degrees) - Mathf.Min(inputDegree, degrees)) > 180)
                {
                    rotationDirection = 1;
                }
                else if (degrees >= inputDegree - 1 && degrees <= inputDegree + 1)
                {
                    rotationDirection = 0;
                }

                degrees += rotationDirection;
                if (degrees >= 180)
                {
                    degrees = -179.9f;
                }
                else if (degrees <= -180)
                {
                    degrees = 179.9f;
                }
            }


            
            currentVector = new Vector2(-Mathf.Sin(degrees * Mathf.Deg2Rad), Mathf.Cos(degrees * Mathf.Deg2Rad));

            GetComponent<Rigidbody2D>().velocity = (currentVector * ((movementSpeed * Input.GetAxis("LeftTriggerController" + ((shipNumber * 2) - 2 + playerControlled))) + 0.01f));

        }
        transform.up = currentVector;

    }
}
