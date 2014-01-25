using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {
    public Texture2D cursor;
    public int size;

    void die()
    {
        this.enabled = false;
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width / 2, Screen.height / 2, size, size * cursor.height / cursor.width), cursor);
    }
}
