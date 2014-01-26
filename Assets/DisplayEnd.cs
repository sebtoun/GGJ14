using UnityEngine;
using System.Collections;
using System;

public class DisplayEnd : MonoBehaviour 
{
    float guiAlpha = 0;
    public float time;
    public Font font;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        iTween.ValueTo(this.gameObject, iTween.Hash(
                "time", 1,
                "from", guiAlpha,
                "to", 0.5f,
                "onupdate", (Action<object>)(v => guiAlpha = (float)v)
                ));
    }

    void OnGUI()
    {
        GUIContent content = new GUIContent("We don't see things as they are, we see them as we are");
        //GUIContent content = new GUIContent("toto");
        GUI.contentColor = Color.white;
        GUI.skin.font = font;
        GUI.skin.label.fontSize = 30;
        var size = GUI.skin.label.CalcSize(content);
        var c = GUI.color;
        c.a = guiAlpha;
        GUI.color = c;
        GUI.Label(new Rect((Screen.width - size.x) / 2, Screen.height * 2 / 3 - size.y / 2, size.x, size.y), content);
    }
}
