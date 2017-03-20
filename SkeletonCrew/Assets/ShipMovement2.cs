using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public float m_TurnSpeed = 1.0f;
    public Transform m_Target = null;

    void Update()
    {
        if (m_Target == null)
        {
            return;
        }

        Vector3 targetLookAtPoint = m_Target.position - transform.position;

        targetLookAtPoint = new Vector3(targetLookAtPoint.x, transform.position.y, targetLookAtPoint.z);
        // Remove this line if your turret is supposed to be able to look up and down
        targetLookAtPoint.Normalize();

        targetLookAtPoint = Vector3.Slerp(transform.forward, targetLookAtPoint, Time.deltaTime * m_TurnSpeed);

        targetLookAtPoint += transform.position;
        transform.LookAt(targetLookAtPoint);
    }
}
