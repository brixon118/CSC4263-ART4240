using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagDamage : MonoBehaviour
{
    public GameObject LinkDamage;
    float dmg = 25;
    RoomsBehavior Phealth;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void ApplyDamage ()
    {
        Phealth = LinkDamage.GetComponent<RoomsBehavior>();
        Phealth.health -= 25;
    }


}
