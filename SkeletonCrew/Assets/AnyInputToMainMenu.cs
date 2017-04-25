using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnyInputToMainMenu : MonoBehaviour
{

	void Start ()
    {
		
	}
	
	void Update ()
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
