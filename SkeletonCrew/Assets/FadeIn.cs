using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour {
    public float counter = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, counter);
        counter = counter + (Time.deltaTime / 3);
    }
}
