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
        { "interaction", "Press Space to open the door" }, 
        { "gun", "I could use this weapon to help my friend" },
        { "start", "They are gone, it's my chance to escape" }, 
        { "end", "You don't see things as they are, we see them as we are" },
    };

    Dictionary<string, Color> hintsColor = new Dictionary<string, Color>
    {
        { "interaction", Color.white }, 
        { "gun", Color.white },
        { "start", Color.black },
        { "end", Color.white },
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
            GUI.contentColor = hintsColor[currentHint];
            GUI.skin.font = font;
            GUI.skin.label.fontSize = 30;
            var size = GUI.skin.label.CalcSize(guiContent);
            var c = GUI.color;
            c.a = guiAlpha;
            GUI.color = c;
            GUI.Label(new Rect((Screen.width - size.x) / 2, Screen.height * 2 / 3 - size.y / 2, size.x, size.y), guiContent);
        }
    }
}
