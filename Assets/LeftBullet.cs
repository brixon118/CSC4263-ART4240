using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBullet : MonoBehaviour {

    public GameObject leftBulletPrefab;
    public Transform lBulletSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0,Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f,0);
        transform.Translate(0,0,Input.GetAxis("Vertical") * Time.deltaTime * 3.0f);

		if (Input.GetKeyDown(KeyCode.S))
        {
            lFire();
            
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
        var lBullet = (GameObject)Instantiate(leftBulletPrefab, lBulletSpawn.position,lBulletSpawn.rotation);
        lBullet.GetComponent<Rigidbody>().velocity = lBullet.transform.forward * 6;
    }

}
