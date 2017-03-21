using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement4 : MonoBehaviour {
    public float movementSpeed = 30;
    public float rotationSpeed = 10;
    public float playerInput;
    public GameObject shipRoot;
    private int shipNumber;
    public GameObject navRoom;
    private int playerControlled;
    private Vector2 velocity;
    private Vector2 prevVector;
    private float degrees;
    Vector2 currentVector;
    Vector2 newVector;
    float currentX;
    float currentY;
    public float inputDegrees;
    // Use this for initialization
    void Start()
    {
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        currentVector = GetComponent<Rigidbody2D>().velocity;
        currentX = currentVector.normalized.x;

        currentY = currentVector.normalized.y;
        degrees = (Mathf.Atan2(currentX, currentY)) + 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        velocity = new Vector2(Input.GetAxis("LeftHorizontalController" + ((shipNumber * 2) - 2 + playerControlled)), Input.GetAxis("LeftVerticalController" + ((shipNumber * 2) - 2 + playerControlled)));
            inputDegrees = Mathf.Atan2(velocity.normalized.x, velocity.normalized.y)*Mathf.Rad2Deg - 0.0001f;

            if (playerControlled != 0)
        {
            

            degrees += 0.00875f;

            currentVector = new Vector2(Mathf.Sin(degrees), Mathf.Cos(degrees));
            Vector2 testest = Quaternion.AngleAxis(1.0f, Vector3.forward) * GetComponent<Rigidbody2D>().velocity;
            Vector2 dir = (Vector2)(Quaternion.Euler(0, 0, inputDegrees) * Vector2.right);
            GetComponent<Rigidbody2D>().velocity = (dir * ((movementSpeed * Input.GetAxis("LeftTriggerController" + ((shipNumber * 2) - 2 + playerControlled))) + 0.01f));
            //if (!currentVector.Equals(Vector2.zero))
            //{
            //prevVector = currentVector;
            //}
            transform.right = dir;
        }
        
        
    }
}
