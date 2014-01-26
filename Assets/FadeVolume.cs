using UnityEngine;
using System.Collections;
using System;

public class FadeVolume : MonoBehaviour 
{
    public float time = 1;
    
    void Start () 
    {
        iTween.ValueTo(this.gameObject, iTween.Hash(
            "time", time,
            "from", 0,
            "to", 1,
            "onupdate", (Action<object>) (v => GetComponent<AudioSource>().volume = (float)v)
            ));
	}
}
