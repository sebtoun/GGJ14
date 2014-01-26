using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
    public Vector3 axis = Vector3.up;
    public float speed = 460;

	void Update () 
    {
        this.transform.Rotate(axis, speed * Time.deltaTime, Space.World);
	}
}
