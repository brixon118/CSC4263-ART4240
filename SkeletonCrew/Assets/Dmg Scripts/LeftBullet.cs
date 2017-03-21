using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBullet : MonoBehaviour {

    private int playerControlled;
    private int shipNumber;
    public GameObject shipRoot;
    public GameObject navRoom;
    public float triggerDown;

    public float speed;
    public GameObject leftGunBullet;
    public Transform lBulletSpawn;
    public GameObject LeftGun;

	// Use this for initialization
	void Start ()
    {
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
    }
	
	// Update is called once per frame
	void Update () {

        transform.rotation = LeftGun.transform.rotation;
        //transform.Translate(0,0,Input.GetAxis("Vertical") * Time.deltaTime * 3.0f);

        playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        if (playerControlled != 0)
        {
            triggerDown = Input.GetAxisRaw("LeftTriggerController" + ((shipNumber * 3) - 2 + playerControlled));
            if (triggerDown == 1)
            {
                lFire();
            }
        }
    }
    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "flakBullet")
        {
            Destroy(gameObject, .05f);
        }
    }

    void lFire()
    {
        //create the bullet from the bullet prefab
        var lBullet = (GameObject)Instantiate(leftGunBullet, lBulletSpawn.position,transform.rotation);
 

        lBullet.GetComponent<Rigidbody2D>().velocity = lBulletSpawn.right* -1 * speed;
        //new Vector2((empty.x - lbulletspan.x), (empty.y - lbulletspawn.y));
        Vector2 currentLocation = transform.position;
        Invoke("detonate", 1.5f);
        Destroy(lBullet, 1.5f);
    }

    void detonate()
    {
        Vector2 currentLocation = transform.position;
        //GetComponent<AOEProjDmg>().AoeApplyDamage(currentLocation, 0.6f, 25);

    }
}
