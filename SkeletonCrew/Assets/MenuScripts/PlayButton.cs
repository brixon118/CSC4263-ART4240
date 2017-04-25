using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {
    public bool buttonActive = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        buttonActive = gameObject.GetComponent<IsButtonActive>().active;
        if (buttonActive)
        {
            for (int i = 2; i < 7; i++)
            {
                if (Input.GetAxisRaw("LeftTriggerController" + i) == 1)
                {
                    SceneManager.LoadScene("MainScene");
                }
                
            }
        }
    }
}
