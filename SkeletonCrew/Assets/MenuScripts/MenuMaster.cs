using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMaster : MonoBehaviour {
    public int index = 0;
    public int numberOfChildren = 0;
	// Use this for initialization
	void Start () {
        foreach (Transform child in transform)
        {
            numberOfChildren++;
        }

    }
	
	// Update is called once per frame
	void Update () {
		if(index < 0)
        {
            index = numberOfChildren - 1;
        }
        else if (index > numberOfChildren - 1)
        {
            index = 0;
        }
        if(!gameObject.transform.GetChild(index).GetComponent<IsButtonActive>().active)
        {
            gameObject.transform.GetChild(index).GetComponent<IsButtonActive>().active = true;
        }

	}
}
