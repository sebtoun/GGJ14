using UnityEngine;
using System.Collections;
using System;

public class flammeOnFire : MonoBehaviour {
    public float time = 0.2f;
    public float intensity = 4;
    public float range = 2;
    void fire()
    {
        light.enabled = true;
        light.intensity = intensity;
        iTween.ValueTo(this.gameObject, iTween.Hash(
            "time", time,
            "from", light.intensity,
            "to", 0,
            "easetype", iTween.EaseType.easeOutExpo,
            "onupdate", (Action<object>) (v => light.intensity = (float)v)
            ));
        light.range = range;
        iTween.ValueTo(this.gameObject, iTween.Hash(
            "time", time,
            "from", light.range,
            "to", 0,
            "easetype", iTween.EaseType.easeOutExpo,
            "onupdate", (Action<object>)(v => light.intensity = (float)v),
            "oncomplete", (Action<object>)(v => { light.enabled = false; })
            ));
    }
}
