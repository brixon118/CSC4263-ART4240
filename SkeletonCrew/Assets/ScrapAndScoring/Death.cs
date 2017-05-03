using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
    public GameObject room1;
    public GameObject room2;
    public GameObject room3;
    public GameObject room4;
    public GameObject room5;
    public GameObject room6;
    public GameObject room7;
    public GameObject room8;
    public GameObject room9;
    public GameObject sinkShipPrefab;
    public GameObject shipSink;
    public GameObject shipOutside;
    public bool ship1 = true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (room1.GetComponent<RoomsBehavior>().waterLevel >= room1.GetComponent<RoomsBehavior>().maxWaterLevel 
            || room2.GetComponent<RoomsBehavior>().waterLevel >= room2.GetComponent<RoomsBehavior>().maxWaterLevel 
            || room3.GetComponent<RoomsBehavior>().waterLevel >= room3.GetComponent<RoomsBehavior>().maxWaterLevel
            || room4.GetComponent<RoomsBehavior>().waterLevel >= room4.GetComponent<RoomsBehavior>().maxWaterLevel
            || room5.GetComponent<RoomsBehavior>().waterLevel >= room5.GetComponent<RoomsBehavior>().maxWaterLevel
            || room6.GetComponent<RoomsBehavior>().waterLevel >= room6.GetComponent<RoomsBehavior>().maxWaterLevel
            || room7.GetComponent<RoomsBehavior>().waterLevel >= room7.GetComponent<RoomsBehavior>().maxWaterLevel
            || room8.GetComponent<RoomsBehavior>().waterLevel >= room8.GetComponent<RoomsBehavior>().maxWaterLevel
            || room9.GetComponent<RoomsBehavior>().waterLevel >= room9.GetComponent<RoomsBehavior>().maxWaterLevel)
        {
            shipSink = Instantiate(sinkShipPrefab, shipOutside.GetComponent<Transform>().position, shipOutside.GetComponent<Transform>().rotation);
            if (ship1)
            {
                shipSink.GetComponent<SinkingShip>().scrapTotal = gameController.playerOneScrap % 200;
            }
            else
            {
                shipSink.GetComponent<SinkingShip>().scrapTotal = gameController.playerTwoScrap % 200;
            }
            shipSink.GetComponent<SinkingShip>().ship1 = ship1;
            Destroy(this.gameObject);
        }
        
    }
}
