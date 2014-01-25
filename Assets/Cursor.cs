using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {
    public Texture2D cursor;
    public int size;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width / 2, Screen.height / 2, size, size * cursor.height / cursor.width), cursor);
    }
}
