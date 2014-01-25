using UnityEngine;
using System.Collections;

public class OnTargetShot : MonoBehaviour {
    public GameObject decalPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void targetWasHit(RaycastHit target)
    {
        if (target.collider.tag == "Alien")
        {
        }
        else if (target.collider.tag == "Man")
        {
        }
        else
        {
            GameObject.Instantiate(decalPrefab, target.point + target.normal * 0.1f, Quaternion.LookRotation(target.normal, Vector3.up));
        }
    }
}
