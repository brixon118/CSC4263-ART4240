using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsBehavior : MonoBehaviour {
    public float maxHealth = 255;
    public float health = 255;
    public float maxWaterLevel = 100;
    public float waterLevel = 0;

	// Use this for initialization
	void Start () {
        InvokeRepeating("UpdateEverySecond", 0, 1.0f);
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<SpriteRenderer>().color = new Color(1.0f, health/100, health/100, 1f);
    }

    // Updates every second
    void UpdateEverySecond()
    {
        if (health <= (maxHealth / 2) && !(waterLevel >= maxWaterLevel))
        {
            waterLevel++;
        }
    }
}
