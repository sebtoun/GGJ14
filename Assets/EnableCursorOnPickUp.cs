using UnityEngine;
using System.Collections;

public class EnableCursorOnPickUp : MonoBehaviour 
{
    void pickUp(GameObject obj)
    {
        if (obj == null || obj.name == "gun")
            GetComponent<Cursor>().enabled = true;
    }
}
