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
    public GameObject emptyTip;

    // Use this for initialization
    void Start () {
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
    }
	
	// Update is called once per frame
	void Update () {
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        //UserInputs();
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
    }
}
