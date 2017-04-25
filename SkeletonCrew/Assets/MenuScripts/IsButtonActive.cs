using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsButtonActive : MonoBehaviour {
    public bool active = false;
    public float vertVal = 0;
    public static bool canSwitchButton = true;
    public float switchRate = 0.3f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (active)
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 1);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1);
        }
        
        vertVal = Input.GetAxisRaw("LeftVerticalController2");
        for (int i = 2; i < 7; i++)
        {
            if (active && canSwitchButton)
            {
                if (Input.GetAxisRaw("LeftVerticalController" + i) == 1)
                {
                    transform.gameObject.GetComponentInParent<MenuMaster>().index--;
                    active = false;
                    canSwitchButton = false;
                    Invoke("canSwitch", switchRate);
                }
                else if (Input.GetAxisRaw("LeftVerticalController" + i) == -1)
                {
                    transform.gameObject.GetComponentInParent<MenuMaster>().index++;
                    active = false;
                    canSwitchButton = false;
                    Invoke("canSwitch", switchRate);
                }
            }
        }
    }

    private void canSwitch()
    {
        canSwitchButton = true;
    }

}