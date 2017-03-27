using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlackRoundScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 1.0f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("FlakableBullet"))
        {
            Destroy(other.gameObject);
        }
    }

}
