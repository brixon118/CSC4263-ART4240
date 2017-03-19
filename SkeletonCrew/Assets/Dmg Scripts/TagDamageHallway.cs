using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagDamageHallway : MonoBehaviour
{
    public GameObject LinkDamage;
    float dmg = 25;
    HallwayBehavior Phealth;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void ApplyDamage()
    {
        Phealth = LinkDamage.GetComponent<HallwayBehavior>();
        Phealth.health -= 25;
    }


}
