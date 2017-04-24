using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlackRoundScript : MonoBehaviour {
    public bool on = false;
    public int shipNumber = 0;
    public GameObject shipRoot;
    public int playerControlled;
    public GameObject room;
	// Use this for initialization
	void Start () {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
        shipNumber = shipRoot.GetComponent<ShipNumber>().shipNumber;
    }
	
	// Update is called once per frame
	void Update () {
        playerControlled = room.GetComponent<SwitchPlayerControls>().playerControlled;
        on = Input.GetAxisRaw("LeftTriggerController" + ((shipNumber * 3) - 2 + playerControlled)) == 1;
        GetComponent<SpriteRenderer>().enabled = on;
        
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("FlakableBullet") && on)
        {
            Destroy(other.gameObject);
        }
    }

}
