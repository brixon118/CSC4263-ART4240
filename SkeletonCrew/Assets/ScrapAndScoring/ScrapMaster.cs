using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapMaster : MonoBehaviour {
    bool fullChildren = true;
    public int[] rounds = 
        { 0, 0, 200, 0, 0, 
        100, 0, 0, 0, 100,
        0, 100, 0, 100, 0,
        0, 0, 200, 0, 0, 
        100, 100, 0, 100, 100};
    public int index = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        fullChildren = true;
        foreach (Transform child in transform)
        {
            fullChildren = fullChildren && !child.GetComponent<AddScrap>().scrapLeft;
        }
        if (fullChildren)
        {
            foreach (Transform child in transform)
            {
                if(index >= rounds.Length)
                {
                    index = 0;
                }
                child.GetComponent<AddScrap>().total = rounds[index];
                index++;
            }
        }
	}
}
