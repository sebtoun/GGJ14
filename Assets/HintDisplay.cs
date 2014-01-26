using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class HintDisplay : MonoBehaviour 
{
    GUIContent guiContent;
    string currentHint;
    float guiAlpha;
    string tweenName;

    public float fadeTime = 1;
    public Font font;

    Dictionary<string, string> hints = new Dictionary<string, string>
    {
        { "interaction", "Press Space to use" }, 
    };

    void Start()
    {
        guiAlpha = 0;
    }

    void showHint(string hint)
    {
        string content;
        if (hints.TryGetValue(hint, out content))
        {
            guiContent = new GUIContent(content);
            currentHint = hint;
            iTween.ValueTo(this.gameObject, iTween.Hash(
                "time", fadeTime,
                "from", guiAlpha,
                "to", 0.5f,
                "onupdate", (Action<object>)(v => guiAlpha = (float)v)
                ));
        }
    }

    void hideHint(string hint)
    {
        if (hint == currentHint)
        {
            iTween.ValueTo(this.gameObject, iTween.Hash(
                "time", fadeTime,
                "from", guiAlpha,
                "to", 0,
                "onupdate", (Action<object>) (v => guiAlpha = (float)v),
                "oncomplete", (Action<object>)(o => { guiContent = null; currentHint = ""; })
                ));
        }
    }

    void OnGUI()
    {
        if (guiContent != null)
        {
            //GUI.skin.font = font;
            GUI.skin.label.fontSize = 30;
            var size = GUI.skin.label.CalcSize(guiContent);
            var c = GUI.color;
            c.a = guiAlpha;
            GUI.color = c;
            GUI.Label(new Rect((Screen.width - size.x) / 2, Screen.height * 2 / 3 - size.y / 2, size.x, size.y), guiContent);
        }
    }
}
