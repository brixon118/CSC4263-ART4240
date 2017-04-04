using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largeBullet : MonoBehaviour {

    public float speed;
    public GameObject largeGunBullet;
    public Transform largeBulletSpawn;
    public GameObject largeGun;

    private int playerControlled;
    private int shipNumber;
    public GameObject shipRoot;
    public GameObject navRoom;
    public float triggerDown;

    // Use this for initialization
    void Start()
    {
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation = largeGun.transform.rotation;
        //transform.Translate(0,0,Input.GetAxis("Vertical") * Time.deltaTime * 3.0f);

        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        if (playerControlled != 0)
        {
            triggerDown = Input.GetAxisRaw("LeftTriggerController" + ((shipNumber * 3) - 2 + playerControlled));
            if (triggerDown == 1)
            {
                largeFire();
            }
        }
    }
    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "flakBullet")
        {
            Destroy(gameObject, .05f);
        }
        else
        {
            Vector2 currentLocation = transform.position;
            //GetComponent<AOEProjDmg>().AoeApplyDamage(currentLocation, 0.8f, 50);
            Destroy(gameObject, 0f);
        }
    }

    void largeFire()
    {
        //create the bullet from the bullet prefab
        var largeBullet = (GameObject)Instantiate(largeGunBullet, largeBulletSpawn.position, transform.rotation);


        largeBullet.GetComponent<Rigidbody2D>().velocity = largeBulletSpawn.up * speed;
        //new Vector2((empty.x - lbulletspan.x), (empty.y - lbulletspawn.y));
        Destroy(largeBullet, 1.5f);
    }
}
