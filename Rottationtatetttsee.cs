using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rottationtatetttsee : MonoBehaviour
{
    private Vector2 velocity;
    private int playerControlled;
    private int shipNumber;
    public GameObject shipRoot;
    public GameObject navRoom;
    public float velocityDegrees;
    public float currentZ;
    public float rotationRate = 50;
    public Wake wake;
    // Use this for initialization
    void Start()
    {
        currentZ = (transform.rotation.z) * 180;
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
    }

    // Update is called once per frame
    void Update()
    {
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        velocity = new Vector2(Input.GetAxis("LeftHorizontalController" + ((shipNumber * 3) - 2 + playerControlled)), Input.GetAxis("LeftVerticalController" + ((shipNumber * 3) - 2 + playerControlled)));
        velocityDegrees = -Mathf.Atan2(-velocity.normalized.x, velocity.normalized.y) * Mathf.Rad2Deg;
        currentZ = (transform.rotation.z) * 180;


        if (!velocity.Equals(Vector2.zero))
        {
            if (velocityDegrees > 0)
            {
                transform.Rotate(-Vector3.forward * rotationRate * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.forward * rotationRate * Time.deltaTime);
            }
        }
        GetComponent<Rigidbody2D>().velocity = (transform.up * ((30 * Input.GetAxis("LeftTriggerController" + ((shipNumber * 3) - 2 + playerControlled)) + 0.0001f)));
        float i = 30 * Input.GetAxis("LeftTriggerController" + ((shipNumber * 3) - 2 + playerControlled));

        if (i == 0f)
        {
            wake.shrink();
        }
        else
        {
            wake.grow();
        }
    }
}