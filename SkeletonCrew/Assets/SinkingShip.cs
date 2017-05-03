using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkingShip : MonoBehaviour
{
    private float counter;
	// Use this for initialization
	void Start ()
    {
        counter = 1;
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
    }
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, counter);
        counter = counter - (Time.deltaTime/3);
    }
}
