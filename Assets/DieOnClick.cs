using UnityEngine;
using System.Collections;

public class DieOnClick : MonoBehaviour {
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.K))
            BroadcastMessage("die");
	}
}
