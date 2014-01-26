using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections.Generic;

public class CanPickUp : MonoBehaviour 
{
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Item")
        {
            BroadcastMessage("pickUp", c.gameObject);
        }
    }
}
