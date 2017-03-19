using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagDamage : MonoBehaviour
{
    public GameObject LinkDamage;
    //float dmg = 25;
    RoomsBehavior Phealth;
    //bool water = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //moved to RoomsBehavior

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

    public void ApplyDamage(float dmg)
    {
        Phealth = LinkDamage.GetComponent<RoomsBehavior>();
        Phealth.health -= dmg;
        //water = true;
    }


}
