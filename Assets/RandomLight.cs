using UnityEngine;
using System.Collections;

public class RandomLight : MonoBehaviour {
    public float avgOff;
    public float maxOff;
    public float avgOn;
    public float maxOn;

	// Use this for initialization
	void Start () {
        StartCoroutine(flickerCo());
	}

    IEnumerator flickerCo()
    {
        while (true)
        {
            BroadcastMessage("turnOn");
            yield return new WaitForSeconds(Mathf.Min(maxOn, - Mathf.Log(Random.value) * avgOn));
            BroadcastMessage("turnOff");
            yield return new WaitForSeconds(Mathf.Min(maxOff, - Mathf.Log(Random.value) * avgOff));
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
