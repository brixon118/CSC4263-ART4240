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

    public class RoomsBehavior : MonoBehaviour
    {
        void OnCollisionStay2D(Collision2D col)
        {
            if (col.gameObject.tag == "Hallway-FrontToRight")
            {
                col.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            }
            if (col.gameObject.tag == "Hallway-RightToLeft")
            {
                col.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            }
            if (col.gameObject.tag == "Hallway-LeftToBack")
            {
                col.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            }
            if (col.gameObject.tag == "Room-Front")
            {
                col.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            }
            if (col.gameObject.tag == "Room-Right")
            {
                col.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            }
            if (col.gameObject.tag == "Room-Left")
            {
                col.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            }
            if (col.gameObject.tag == "Room-Back")
            {
                col.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            }
            //col.gameObject.SendMessage("ApplyDamage", 10);

        }
    }

    //void OnCollisionEnter2D(Collision2D col)
    //{
    //    Physics.OverlapSphere(BallisticProjectilePosition, AOERadius);
    //}
}