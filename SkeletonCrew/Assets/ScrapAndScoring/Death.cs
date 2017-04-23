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
    public GameObject scrapNodePrefab;
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
            if (ship1)
            {
                scrapNodePrefab.GetComponent<AddScrap>().total = gameController.playerOneScrap % 200;
            }
            else
            {
                scrapNodePrefab.GetComponent<AddScrap>().total = gameController.playerTwoScrap % 200;
            }
            Instantiate(scrapNodePrefab, this.gameObject.transform.GetChild (0).transform);
            Destroy(this.gameObject);
        }
        
    }
}
