using UnityEngine;
using System.Collections;

public class EnableShootOnPickup : MonoBehaviour {
    void pickUp(GameObject obj)
    {
        if (obj == null || obj.name == "gun")
        {
            GetComponent<Shoot>().enabled = true;
        }
    }
}
