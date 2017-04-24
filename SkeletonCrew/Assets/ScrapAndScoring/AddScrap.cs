using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScrap : MonoBehaviour {
    bool canInvoke = true;
    public int nodeWorth = 5;
    public int total = 100;
    public bool scrapLeft = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scrapLeft = total > 0;
        GetComponent<SpriteRenderer>().enabled = scrapLeft;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (canInvoke && collision.tag == "ShipOutside" && scrapLeft)
        {
            collision.GetComponent<ScrapStorage>().currentScrap += nodeWorth;
            total -= nodeWorth;
            canInvoke = false;
            Invoke("UpdateEverySecond", 1.0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ShipOutside")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            audio.Play(44100);
        }
    }

    void UpdateEverySecond()
    {
        canInvoke = true;
    }

}
