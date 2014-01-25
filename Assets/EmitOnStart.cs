using UnityEngine;
using System.Collections;

public class EmitOnStart : MonoBehaviour {
    public int count = 15;
	// Use this for initialization
	void Start () {
        GetComponent<ParticleSystem>().Emit(count);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
