using UnityEngine;
using System.Collections;

public class LookDownward : MonoBehaviour 
{
	IEnumerator Start () 
    {
        yield return new WaitForSeconds(0.2f);
        transform.LookAt(transform.parent);
	}
}
