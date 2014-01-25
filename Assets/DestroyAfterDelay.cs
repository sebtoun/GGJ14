using UnityEngine;
using System.Collections;

public class DestroyAfterDelay : MonoBehaviour {
    public float delay;
	// Use this for initialization
	IEnumerator Start () {
        yield return new WaitForSeconds(delay);
        Destroy(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
