using UnityEngine;
using System.Collections;
using System;

public class Recoil : MonoBehaviour 
{
    public float time = 0.2f;
    public float recover = 0.4f;
    public Vector3 amount = Vector3.zero;
    Vector3 initialPos;
    void Start()
    {
        initialPos = transform.localPosition;
    }
    void fire()
    {
        iTween.MoveTo(this.gameObject, iTween.Hash(
            "time", time,
            "position", initialPos + amount,
            "islocal", true,
            //"easetype", iTween.EaseType.easeOutExpo,
            "oncomplete", (Action<object>) (o => iTween.MoveTo(this.gameObject, iTween.Hash(
                "time", recover,
                "position", initialPos,
                "islocal", true,
                "easetype", iTween.EaseType.easeOutExpo
                )))
            ));

    }
}
