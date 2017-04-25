using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
    public float upperLimit = 50;
    public float lowerLimit = -50;
    public float fireRate = 0.5f;
    public float rotationRate = 50;
    public GameObject gunBullet;
    public bool left = true;
    public float timeOn = 20;
    public float timeOff = 60;
    public float timeToBegin = 1;
    public Sprite replacementSprite;
    bool usable = false;
	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().flipX = left;
        GetComponent<SpriteRenderer>().enabled = false;
        Invoke("available", timeToBegin);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (usable && collision.tag == "ShipOutside")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            audio.Play(44100);
            if (left)
            {
                collision.GetComponent<GunList>().leftGun.GetComponent<Gun>().upperLimit = upperLimit + 180;
                collision.GetComponent<GunList>().leftGun.GetComponent<Gun>().lowerLimit = lowerLimit + 180;
                collision.GetComponent<GunList>().leftGun.GetComponent<Gun>().fireRate = fireRate;
                collision.GetComponent<GunList>().leftGun.GetComponent<Gun>().gunBullet = gunBullet;
                collision.GetComponent<GunList>().leftGun.GetComponent<Gun>().rotationRate = rotationRate;
                if(replacementSprite != null)
                {
                    collision.GetComponent<GunList>().leftGun.GetComponent<SpriteRenderer>().sprite = replacementSprite;
                }
            }
            else
            {
                collision.GetComponent<GunList>().rightGun.GetComponent<Gun>().upperLimit = upperLimit;
                collision.GetComponent<GunList>().rightGun.GetComponent<Gun>().lowerLimit = lowerLimit;
                collision.GetComponent<GunList>().rightGun.GetComponent<Gun>().fireRate = fireRate;
                collision.GetComponent<GunList>().rightGun.GetComponent<Gun>().gunBullet = gunBullet;
                collision.GetComponent<GunList>().rightGun.GetComponent<Gun>().rotationRate = rotationRate;
                if (replacementSprite != null)
                {
                    collision.GetComponent<GunList>().rightGun.GetComponent<SpriteRenderer>().sprite = replacementSprite;
                }
            }
            notAvailable();
        }

    }

    private void available()
    {
        usable = true;
        GetComponent<SpriteRenderer>().enabled = true;
        Invoke("notAvailable", timeOn);
    }

    private void notAvailable()
    {
        usable = false;
        GetComponent<SpriteRenderer>().enabled = false;
        Invoke("available", timeOff);
    }
}
