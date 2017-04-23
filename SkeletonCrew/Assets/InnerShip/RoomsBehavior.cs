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
                waterLevel++;
            }
            
        }
        else if(waterLevel > 0)
        {
            waterLevel--;
        }

        if (repairable && storage.currentScrap > 4 && health < maxHealth)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            audio.Play(44100);
            storage.currentScrap -= 5;
            health += 5;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        PlayersController player = collision.gameObject.GetComponent<PlayersController>();
        if (player.controlled && Input.GetAxisRaw("LeftTriggerController" + ((shipNumber * 3) - 2 + player.playerNumber)) == 1)
        {
            repairable = true;
        }
        else
        {
            repairable = false;
        }
    }

}
