using UnityEngine;
using System.Collections;
using System;

public class TimeScaleOnBlackOut : MonoBehaviour {
    void blackOut()
    {
        iTween.ValueTo(this.gameObject, iTween.Hash(
            "time", 1,
            "from", 0.8f,
            "to", 1f,
            "onupdate", (Action<object>)(v => Time.timeScale = (float)v)
            ));
        Debug.Log("coucou");
        SendMessage("showHint", "end");
        Debug.Log(GameObject.Find("head_go(clone)"));
    }
   
}
