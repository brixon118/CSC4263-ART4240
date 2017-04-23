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
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ShipOutside")
        {
            if (left)
            {
                collision.GetComponent<GunList>().leftGun.GetComponent<Gun>().upperLimit = upperLimit + 180;
                collision.GetComponent<GunList>().leftGun.GetComponent<Gun>().lowerLimit = lowerLimit + 180;
                collision.GetComponent<GunList>().leftGun.GetComponent<Gun>().fireRate = fireRate;
                collision.GetComponent<GunList>().leftGun.GetComponent<Gun>().gunBullet = gunBullet;
                collision.GetComponent<GunList>().leftGun.GetComponent<Gun>().rotationRate = rotationRate;
            }
            else
            {
                collision.GetComponent<GunList>().rightGun.GetComponent<Gun>().upperLimit = upperLimit;
                collision.GetComponent<GunList>().rightGun.GetComponent<Gun>().lowerLimit = lowerLimit;
                collision.GetComponent<GunList>().rightGun.GetComponent<Gun>().fireRate = fireRate;
                collision.GetComponent<GunList>().rightGun.GetComponent<Gun>().gunBullet = gunBullet;
                collision.GetComponent<GunList>().rightGun.GetComponent<Gun>().rotationRate = rotationRate;
            }
            Destroy(this.gameObject);
        }

    }
}
