using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOEProjDmg : MonoBehaviour
{
    public bool WhenLand = false;  //True when ballistic lands, else false
    Vector3 BallisticProjectilePosition;
    public float AOERadius = 0.6f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (WhenLand == true)
        {
            WhenLand = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Physics.OverlapSphere(BallisticProjectilePosition, AOERadius);
    }
}