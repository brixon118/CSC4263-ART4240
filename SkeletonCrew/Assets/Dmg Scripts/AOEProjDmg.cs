using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOEProjDmg : MonoBehaviour
{
    public Vector3 BallisticProjectilePosition;
    public float AOERadius = 0.6f;
    public Transform trans;
    public float dmg = 25;

    // Use this for initialization
    void Start()
    {
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(trans.position.z <= 0)
        {
            //Vector2 currentPosition = trans.position;
            //AoeApplyDamage(trans.position, AOERadius, dmg);
        }
        
    }

    public void AoeApplyDamage(Vector2 loc, float radius, float dmg)
    {
        Collider2D[] objectsInRange = Physics2D.OverlapCircleAll(loc, radius);
        foreach (Collider2D col in objectsInRange)
        {
            if (col.CompareTag("RoomCollider"))
            {
                col.GetComponent<TagDamage>().ApplyDamage(dmg);
            }
        }
    }
}