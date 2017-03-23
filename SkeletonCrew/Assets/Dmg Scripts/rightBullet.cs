using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightBullet : MonoBehaviour {

    public float speed = 10;
    private bool triggerUp = true;
    public float dmg = 10;
    public Sprite explosion;
    private Vector2 bulletPath;
    public float bulletLife = 1.0f;

    // Use this for initialization
    void Start()
    {
        Invoke("detonate", bulletLife);
        bulletPath = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        //playerControlled = navRoom.GetComponent<SwitchPlayerControls>().playerControlled;
        GetComponent<Rigidbody2D>().velocity = bulletPath;
    }

    public void detonate()
    {
        GetComponent<SpriteRenderer>().sprite = explosion;
        bulletPath = Vector2.zero;
        GetComponent<AOEProjDmg>().AoeApplyDamage(transform.position, 0.6f, dmg);
        Destroy(gameObject, 0.2f);
    }


    void OnCollisionEnter2D(Collision2D otherObj)
    {
        detonate();
/*
        if (otherObj.gameObject.tag == "flakBullet")
        {
            Destroy(gameObject);
        }
        else 
        {
            
        }
*/
    }

<<<<<<< HEAD
=======
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
        //GetComponent<AOEProjDmg>().AoeApplyDamage(currentLocation, 0.6f, 25);
        
    }
>>>>>>> origin/robinMVP2
}
