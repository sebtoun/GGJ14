using UnityEngine;
using System.Collections;

public class LookDownward : MonoBehaviour 
{
	void Start () 
    {
        transform.LookAt(transform.parent);
	}
}
