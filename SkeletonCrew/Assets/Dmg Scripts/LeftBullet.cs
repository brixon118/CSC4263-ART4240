using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBullet : MonoBehaviour {

    public float speed = 250;
    private bool triggerUp = true;
    private Vector2 bulletPath;
    public float bulletLife = 0.1f;

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
        
        Destroy(gameObject);
    }

}
