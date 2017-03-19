using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class THEFrontRoomHealthDisplay : MonoBehaviour
{
    public GameObject HealthDisplay;
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
        textie.text = " " + HealthDisplay.GetComponent<RoomsBehavior>().health;
    }
}