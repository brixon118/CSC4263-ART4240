using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {
    public bool buttonActive = false;
    public bool canLoad = true;
	// Use this for initialization
	void Start () {
        //SceneManager.LoadSceneAsync("MainScene", LoadSceneMode.Additive);
	}
	
	// Update is called once per frame
	void Update () {
        buttonActive = gameObject.GetComponent<IsButtonActive>().active;
        if (buttonActive)
        {
            //for (int i = 2; i < 7; i++)
            //{
            if (canLoad && (Input.GetButtonDown("LeftBumperController2") || Input.GetButtonDown("LeftBumperController3") || Input.GetButtonDown("LeftBumperController5") || Input.GetButtonDown("LeftBumperController6") || Input.GetAxisRaw("LeftTriggerController2") > 0 || Input.GetAxisRaw("LeftTriggerController3") > 0 || Input.GetAxisRaw("LeftTriggerController5") > 0 || Input.GetAxisRaw("LeftTriggerController6") > 0))
            {
                SceneManager.LoadScene("MainScene");
                canLoad = false;  
            }
                
            //}
        }
    }
}
