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
    }

}
