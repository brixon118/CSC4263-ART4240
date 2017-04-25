using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsBehavior : MonoBehaviour {
    public float maxHealth = 100;
    public float health = 100;
    public float maxWaterLevel = 100;
    public float waterLevel = 0;
    public int shipNumber = 0;
    public GameObject shipOutside;
    public float floodingSpeed = 10;
    public float drainingSpeed = 5;
    public float repairRate = 10;
    public int repairCost = 5;
    ScrapStorage storage;
    bool repairable = false;

    // Use this for initialization
    void Start()
    {
        storage = shipOutside.GetComponent<ScrapStorage>();
        InvokeRepeating("UpdateEverySecond", 0, 1.0f);
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<SpriteRenderer>().color = new Color(1.0f, health/100, health/100, 1f);
        
    }

    // Updates every second
    void UpdateEverySecond()
    {
        if (health <= (maxHealth / 2))
        {
            if (waterLevel < maxWaterLevel)
            {
                waterLevel += floodingSpeed * waterLevel / maxWaterLevel;
            }
            
        }
        else if(waterLevel > 0)
        {
            waterLevel -= drainingSpeed;
        }

        if (repairable && storage.currentScrap % 200 > 4 && health < maxHealth)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            audio.Play(44100);
            storage.currentScrap -= repairCost;
            health += repairRate;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        PlayersController player = collision.gameObject.GetComponent<PlayersController>();
        if (player.controlled)
        {
            if (Input.GetAxisRaw("LeftTriggerController" + ((shipNumber * 3) - 2 + player.playerNumber)) == 1)
            {
                repairable = true;
                collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            }
            else
            {
                repairable = false;
                collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            }
            
        }
        else
        {
            repairable = false;
        }
    }

}
