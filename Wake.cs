﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wake : MonoBehaviour {



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void grow()
    {
        if(transform.localScale.y < 1f)
            transform.localScale += new Vector3(0,0.05f,0);
    }

    public void shrink()
    {
        if (transform.localScale.y > .18f)
            transform.localScale -= new Vector3(0, 0.05f, 0);
    }
}
