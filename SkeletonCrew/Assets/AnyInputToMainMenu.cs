using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnyInputToMainMenu : MonoBehaviour
{
    public bool canLoad = true;
	void Start ()
    {
		
	}
	
	void Update ()
    {
		
            if(canLoad && (Input.GetButtonDown("LeftBumperController2") || Input.GetButtonDown("LeftBumperController3") || Input.GetButtonDown("LeftBumperController5") || Input.GetButtonDown("LeftBumperController6") || Input.GetAxisRaw("LeftTriggerController2") > 0 || Input.GetAxisRaw("LeftTriggerController3") > 0 || Input.GetAxisRaw("LeftTriggerController5") > 0 || Input.GetAxisRaw("LeftTriggerController6") > 0))
            {
                SceneManager.LoadScene("MainMenu");
                canLoad = false;
            }
            
        
		/*if(Input.anyKeyDown == true)
        {
            Getout();
        }*/
	}
    public void Getout ()
    {
        for(int i = 2; i<=6; i++)
        {
            if(Input.GetButtonDown("LeftBumperController" + i))
            {
                SceneManager.LoadScene("MainMenu");
            }
            else if (Input.GetAxisRaw("LeftTriggerController" + i) > 0)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }

}
