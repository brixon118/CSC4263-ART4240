using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomHealthAndWaterDisplay : MonoBehaviour {

    public GameObject room;
    public static Text textie;
    private RoomsBehavior roomie;

    // Use this for initialization
    void Start()
    {
        textie = GetComponent<Text>();
        roomie = room.GetComponent<RoomsBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        textie.text = "Health: " + roomie.health + "\n WaterLevel: " + roomie.waterLevel;
    }
}
