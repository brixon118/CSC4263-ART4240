using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMeasurer : MonoBehaviour {

    public float maxWater = 0;
	// Use this for initialization
	void Start () {
        maxWater = gameObject.GetComponentInParent<RoomsBehavior>().maxWaterLevel;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<SpriteRenderer>().color = new Color(1 - gameObject.GetComponentInParent<RoomsBehavior>().waterLevel / maxWater, 1 - gameObject.GetComponentInParent<RoomsBehavior>().waterLevel / maxWater, 1, 1);
	}
}
