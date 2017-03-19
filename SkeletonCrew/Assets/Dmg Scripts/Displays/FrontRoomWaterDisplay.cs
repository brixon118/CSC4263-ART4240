using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrontRoomWaterDisplay : MonoBehaviour
{
    public GameObject WaterDisplay;
    public static Text textie;
    private RoomsBehavior roomie;

    // Use this for initialization
    void Start()
    {
        textie = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textie.text = " " + WaterDisplay.GetComponent<RoomsBehavior>().waterLevel;
    }
}