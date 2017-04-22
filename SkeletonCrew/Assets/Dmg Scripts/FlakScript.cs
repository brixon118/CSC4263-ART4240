<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlakScript : MonoBehaviour {

    private Vector2 velocity;
    private int playerControlled;
    private int shipNumber;
    public GameObject gunBullet;
    public GameObject shipRoot;
    public GameObject navRoom;
    public float velocityDegrees;
    public float currentZ;
    public float rotationRate = 50;
    public float fireRate = 0.5f;
    private bool canFire = true;
    public bool toggleRotation = true;

    // Use this for initialization
    void Start()
    {
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
        currentZ = (transform.rotation.z) * 180;
    }

    // Update is called once per frame
    void Update () {
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        if (playerControlled != 0)
        {
            if (canFire && Input.GetAxisRaw("LeftTriggerController" + ((shipNumber * 3) - 2 + playerControlled)) == 1)
            {
                rFire();
                canFire = false;
                Invoke("setCanFire", fireRate);
            }
            velocity = new Vector2(Input.GetAxis("LeftHorizontalController" + ((shipNumber * 3) - 2 + playerControlled)), Input.GetAxis("LeftVerticalController" + ((shipNumber * 3) - 2 + playerControlled)));
            velocityDegrees = -Mathf.Atan2(-velocity.normalized.x, velocity.normalized.y) * Mathf.Rad2Deg;


            if (!velocity.Equals(Vector2.zero) && toggleRotation)
            {
                if (velocityDegrees < 0)
                {
                    transform.Rotate(Vector3.forward * rotationRate * Time.deltaTime);
                    currentZ += rotationRate * Time.deltaTime;
                }
                else
                {
                    transform.Rotate(Vector3.forward * -rotationRate * Time.deltaTime);
                    currentZ += -rotationRate * Time.deltaTime;
                }
            }
        }

    }
    void setCanFire()
    {
        canFire = true;
    }
    void rFire()
    {
        Instantiate(gunBullet, transform.position + transform.right - Vector3.forward, transform.rotation);
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
    }
}
||||||| merged common ancestors
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlakScript : MonoBehaviour {

    private Vector2 velocity;
    private int playerControlled;
    private int shipNumber;
    public GameObject gunBullet;
    public GameObject shipRoot;
    public GameObject navRoom;
    public float velocityDegrees;
    public float currentZ;
    public float rotationRate = 50;
    public float fireRate = 0.5f;
    private bool canFire = true;
    public bool toggleRotation = true;

    // Use this for initialization
    void Start()
    {
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
        currentZ = (transform.rotation.z) * 180;
    }

    // Update is called once per frame
    void Update () {
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        if (playerControlled != 0)
        {
            if (canFire && Input.GetAxisRaw("LeftTriggerController" + ((shipNumber * 3) - 2 + playerControlled)) == 1)
            {
                rFire();
                canFire = false;
                Invoke("setCanFire", fireRate);
            }
            velocity = new Vector2(Input.GetAxis("LeftHorizontalController" + ((shipNumber * 3) - 2 + playerControlled)), Input.GetAxis("LeftVerticalController" + ((shipNumber * 3) - 2 + playerControlled)));
            velocityDegrees = -Mathf.Atan2(-velocity.normalized.x, velocity.normalized.y) * Mathf.Rad2Deg;


            if (!velocity.Equals(Vector2.zero) && toggleRotation)
            {
                if (velocityDegrees < 0)
                {
                    transform.Rotate(Vector3.forward * rotationRate * Time.deltaTime);
                    currentZ += rotationRate * Time.deltaTime;
                }
                else
                {
                    transform.Rotate(Vector3.forward * -rotationRate * Time.deltaTime);
                    currentZ += -rotationRate * Time.deltaTime;
                }
            }
        }

    }
    void setCanFire()
    {
        canFire = true;
    }
    void rFire()
    {
        Instantiate(gunBullet, transform.position + transform.right - Vector3.forward, transform.rotation);
    }
}
>>>>>>> master
