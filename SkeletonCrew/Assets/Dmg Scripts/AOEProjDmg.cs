using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOEProjDmg : MonoBehaviour
{
    

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AoeApplyDamage(Vector2 loc, float radius, float dmg)
    {
        Collider2D[] objectsInRange = Physics2D.OverlapCircleAll(loc, radius);
        foreach (Collider2D col in objectsInRange)
        {
            if (col.CompareTag("RoomCollider"))
            {
                col.GetComponent<TagDamage>().ApplyDamage(dmg);
                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();
                audio.Play(44100);
            }
        }
    }
}