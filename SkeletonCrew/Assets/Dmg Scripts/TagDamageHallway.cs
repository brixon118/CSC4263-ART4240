﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagDamageHallway : MonoBehaviour
{
    public GameObject LinkDamage;
    float dmg = 25;
    HallwayBehavior Phealth;
    //bool water = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //moved to HallwayBehavior

        /*if (water == true)
        {
            if (Phealth.waterLevel >= 0)
            {
                Phealth.waterLevel += Time.deltaTime;
            }
            else
            {
                water = false;
            }
        }*/
    }

    void ApplyDamage()
    {
        Phealth = LinkDamage.GetComponent<HallwayBehavior>();
        Phealth.health -= 25;
        //water = true;
    }


}
