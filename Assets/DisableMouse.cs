using UnityEngine;
using System.Collections;

public class DisableMouse : MonoBehaviour 
{
	void Start () 
    {
        Screen.lockCursor = true;
        Screen.showCursor = false;
	}
}
