using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {
    public static int playerOneScrap;
    public static int playerTwoScrap;
    public GameObject ship1;
    public GameObject ship1Prefab;
    public GameObject ship2;
    public GameObject ship2Prefab;
    private bool canSpawn1 = true;
    private bool canSpawn2 = true;
    // Use this for initialization
    void Start () {
        playerOneScrap = 0;
        playerTwoScrap = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (canSpawn1 && ship1 == null && ship2 != null)
        {
            Invoke("respawnShip1", 3.0f);
            canSpawn1 = false;
        }
        if (canSpawn2 && ship2 == null && ship1 != null)
        {
            Invoke("respawnShip2", 3.0f);
            canSpawn2 = false;
        }
        /*
        if (ship1 == null && ship2 == null)
        {

        }
        */
    }

    private void respawnShip1()
    {
        float x = 100;
        float y = 100;
        if (ship2.transform.GetChild(0).transform.position.x > 0)
        {
            x *= -1;
        }
        if (ship2.transform.GetChild(0).transform.position.y > 0)
        {
            y *= -1;
        }

        ship1 = Instantiate(ship1Prefab, new Vector3(x, y, 0) , transform.rotation);
        canSpawn1 = true;
    }

    private void respawnShip2()
    {
        float x = 250;
        float y = 250;
        if (ship1.transform.GetChild (0).gameObject.transform.position.x > 0)
        {
            x *= -1;
        }
        if (ship1.transform.GetChild(0).transform.position.y > 0)
        {
            y *= -1;
        }

        ship2 = Instantiate(ship2Prefab, new Vector3(x, y, 0), transform.rotation);
        canSpawn2 = true;
    }
}
