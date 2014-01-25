using UnityEngine;
using System.Collections;
using System;

public class OverlayOnDeath : MonoBehaviour {
    public float time = 1;
    public float amount = 2;
    void die()
    {
        ScreenOverlay overlay = GetComponent<ScreenOverlay>();
        overlay.intensity = 0;
        overlay.enabled = true;
        iTween.ValueTo(this.gameObject, iTween.Hash(
            "time", time,
            "from", 0,
            "to", amount,
            "onupdate", (Action<object>) (v => overlay.intensity = (float)v)
            ));
    }
}
