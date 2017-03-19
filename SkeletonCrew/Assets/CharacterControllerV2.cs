using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerV2 : MonoBehaviour {
    //private Vector2 velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    public int playerNumber = 1;
    public float speed = 2;
    private Vector2 prevVector;
    public bool controlled = true;
    private Vector2 velocity;
    //public GameObject parentObject;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (controlled)
        {
            velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            GetComponent<Rigidbody2D>().velocity = (velocity * speed);
            if (!velocity.Equals(Vector2.zero))
            {
                prevVector = GetComponent<Rigidbody2D>().velocity.normalized;
            }
        }
        transform.up = prevVector;
    }

    public void switchControlled()
    {
        controlled = !controlled;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
}
