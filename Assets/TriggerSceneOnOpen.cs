using UnityEngine;
using System.Collections;

public class TriggerSceneOnOpen : MonoBehaviour {
    Orchester orchester;	
	void Start () 
    {
        orchester = FindObjectOfType<Orchester>();	
	}
    void open()
    {
        orchester.BroadcastMessage("endScene");
    }
}
