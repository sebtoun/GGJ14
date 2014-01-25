using UnityEngine;
using System.Collections;
using System;

public class DecayIntensity : MonoBehaviour {
    public float time;
	// Use this for initialization
	void Start () {
        iTween.ValueTo(this.gameObject, iTween.Hash(
            "time", time,
            "from", light.intensity,
            "to", 0,
            "easetype", iTween.EaseType.easeOutExpo,
            "onupdate", (Action<object>) (v => light.intensity = (float) v)
            ));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
