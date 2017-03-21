using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightBullet : MonoBehaviour {

    public float speed;
    public GameObject rightGunBullet;
    public Transform rBulletSpawn;
    public GameObject RightGun;
    public float triggerDown;

    private int playerControlled;
    private int shipNumber;
    public GameObject shipRoot;
    public GameObject navRoom;

    // Use this for initialization
    void Start()
    {
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
    }

    // Update is called once per frame
    void Update()
    {
            transform.rotation = RightGun.transform.rotation;
        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        if (playerControlled != 0)
        {
            triggerDown = Input.GetAxisRaw("LeftTriggerController" + ((shipNumber * 2) - 2 + playerControlled));
            if (triggerDown == 1)
            {
                 rFire();
            }
        }


        //transform.Translate(0,0,Input.GetAxis("Vertical") * Time.deltaTime * 3.0f);

        
    }
    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "flakBullet")
        {
            Destroy(gameObject, .05f);
        }
    }

    void rFire()
    {
        //create the bullet from the bullet prefab
        var rBullet = (GameObject)Instantiate(rightGunBullet, rBulletSpawn.position, transform.rotation);


        rBullet.GetComponent<Rigidbody2D>().velocity = rBulletSpawn.right * speed;
        //new Vector2((empty.x - lbulletspan.x), (empty.y - lbulletspawn.y));
        Invoke("detonate", 1.5f);
        Destroy(rBullet, 1.5f);
    }

    void detonate()
    {
        Vector2 currentLocation = transform.position;
        GetComponent<AOEProjDmg>().AoeApplyDamage(currentLocation, 0.6f, 25);
        
    }
}
