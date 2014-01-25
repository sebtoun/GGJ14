using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CanOpenDoors : MonoBehaviour {
    HashSet<GameObject> doors;
	void Start () 
    {
        doors = new HashSet<GameObject>();
	}
	
	void Update () 
    {
        if (doors.Count > 0 && Input.GetButtonDown("Fire2"))
            foreach (var door in doors)
                door.SendMessage("open");
	}

    void OnGUI()
    {
        if (doors.Count > 0)
        {
            GUIContent label = new GUIContent("Press Space to interact with environment");
            GUI.skin.label.fontSize = 30;
            GUI.Label(new Rect(10, 10, 300, 50), label);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Door")
            doors.Add(col.gameObject);
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Door")
            doors.Remove(col.gameObject);
    }
}
