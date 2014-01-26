using UnityEngine;
using System.Collections;

public class EnableShootOnPickup : MonoBehaviour {
    void pickUp(GameObject obj)
    {
        Debug.Log(obj);
        if (obj.name == "gun")
        {
            GetComponent<Shoot>().enabled = true;
        }
    }
}
