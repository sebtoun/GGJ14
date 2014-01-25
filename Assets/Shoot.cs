using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    public LayerMask shootable;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)), out hit, 100f, shootable))
            {
                SendMessage("targetWasHit", hit);
            }
            //SendMessage("die");
        }
	}

    void OnDrawGizmos()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Gizmos.color = Color.white;
            Gizmos.DrawRay(Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)));
        }
    }
}
