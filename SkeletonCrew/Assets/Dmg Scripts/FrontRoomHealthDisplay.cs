using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrontRoomHealthDisplay : MonoBehaviour
{
    public GameObject HealthDisplay;
    public static Text textie;

    // Use this for initialization
    void Start()
    {
        textie = GetComponent<FrontRoomHealth>;
    }

    // Update is called once per frame
    void Update()
    {
        textie.text = "" + GetComponent<RoomsBehavior>().health;
    }
}