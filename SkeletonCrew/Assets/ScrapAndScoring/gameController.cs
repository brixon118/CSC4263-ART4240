﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {
    public static int playerOneScrap = 0;
    public static int playerTwoScrap = 0;
    public int scoreLimit = 1000;
    public int finalDrop = 200;
    public GameObject ship1;
    public GameObject ship1Prefab;
    public GameObject ship2;
    public GameObject ship2Prefab;
    public float respawnTime = 3.0f;
    private bool canSpawn1 = true;
    private bool canSpawn2 = true;
    public float respawnX = 100;
    public float respawnY = 40;
    
    // Use this for initialization
    void Start () {
        playerOneScrap = 0;
        playerTwoScrap = 0;
        respawnShip1();
        respawnShip2();
}
	
	// Update is called once per frame
	void Update () {

        if(ship1 == null)
        {
            if (playerTwoScrap >= scoreLimit)
            {
                Destroy(ship1);
                Destroy(ship2);
                SceneManager.LoadScene("P2 win");
            }
            else if (canSpawn1)
            {
                Invoke("respawnShip1", respawnTime);
                canSpawn1 = false;
            }
        }
        if (ship2 == null)
        {
            if (playerOneScrap >= scoreLimit)
            {
                Destroy(ship1);
                Destroy(ship2);
                SceneManager.LoadScene("P1 win");
            }
            else if (canSpawn2)
            {
                Invoke("respawnShip2", respawnTime);
                canSpawn2 = false;
            }
        }
    }

    private void respawnShip1()
    {
        
        float x = -respawnX;
        float y = -respawnY;
        if (ship2 != null)
        {
            if (ship2.transform.GetChild(0).transform.position.x < 0)
            {
                x *= -1;
            }
            if (ship2.transform.GetChild(0).transform.position.y < 0)
            {
                y *= -1;
            }
        }
        if (playerOneScrap > scoreLimit)
        {
            playerOneScrap = scoreLimit - finalDrop;
        }
        else
        {
            playerOneScrap -= playerOneScrap % 200;
        }
        
        ship1 = Instantiate(ship1Prefab, new Vector3(x, y, 0) , transform.rotation);
        canSpawn1 = true;
    }

    private void respawnShip2()
    {
        float x = respawnX;
        float y = respawnY;
        if (ship1 != null)
        {
            if (ship1.transform.GetChild(0).gameObject.transform.position.x > 0)
            {
                x *= -1;
            }
            if (ship1.transform.GetChild(0).transform.position.y > 0)
            {
                y *= -1;
            }
        }
        if (playerTwoScrap > scoreLimit)
        {
            playerTwoScrap = scoreLimit - finalDrop;
        }
        else
        {
            playerTwoScrap -= playerTwoScrap % 200;
        }

        ship2 = Instantiate(ship2Prefab, new Vector3(x, y, 0), transform.rotation);
        canSpawn2 = true;
    }
}
