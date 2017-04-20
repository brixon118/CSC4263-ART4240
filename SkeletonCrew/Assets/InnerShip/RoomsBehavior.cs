using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsBehavior : MonoBehaviour {
    public float maxHealth = 100;
    public float health = 100;
    public float maxWaterLevel = 100;
    public float waterLevel = 0;
	public GameObject WholeShip1;

	// Use this for initialization
	void Start () {
        InvokeRepeating("UpdateEverySecond", 0, 1.0f);

    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<SpriteRenderer>().color = new Color(1.0f, health/100, health/100, 1f);
    }

    // Updates every second
    void UpdateEverySecond()
    {
        if (health <= (maxHealth / 2) && !(waterLevel >= maxWaterLevel))
        {
            waterLevel++;
        }
		if (waterLevel >= 100) {
			waterLevel = 0;
			if(gameObject != null)
				Respawn ();
		}
    }

	void Respawn()
	{
		Destroy (transform.parent.parent.gameObject, 2.0f);
		//yield return new WaitForSeconds (5.0f);
		WholeShip1 = (GameObject)Instantiate (WholeShip1, new Vector3 (-81, 45, 0), Quaternion.identity) as GameObject;
		//transform.parent.gameObject = spawnPoint.position;

	}
}
