using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateWater : MonoBehaviour {
    public Sprite[] frames;
    public Sprite frame1;
    public Sprite frame2;
    public Sprite frame3;
    public Sprite frame4;
    public Sprite frame5;
    public float frameRate = .5f;
    public int frameIndex = 0;
    // Use this for initialization
    void Start () {
        frames = new Sprite[5];
        frames[0] = frame1;
        frames[1] = frame2;
        frames[2] = frame3;
        frames[3] = frame4;
        frames[4] = frame5;
        Invoke("ChangeFrame", frameRate);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void ChangeFrame()
    {
        GetComponent<SpriteRenderer>().sprite = frames[frameIndex];
        frameIndex++;
        if (frameIndex == 5) {
            frameIndex = 0;
        }
        Invoke("ChangeFrame", frameRate);
    }
}
