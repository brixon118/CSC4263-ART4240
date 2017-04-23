using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour {

    public float time = 2.0f;

    // Use this for initialization
    void Start () {
        Invoke("deleteSelf", time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void deleteSelf()
    {
        Destroy(gameObject, 0.2f);
    }
}
