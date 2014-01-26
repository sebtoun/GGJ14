using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections.Generic;

public class CanPickUp : MonoBehaviour 
{
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.G))
    //        BroadcastMessage("pickUp", new GameObject("gun"));
    //}
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Item") 
        {
            BroadcastMessage("pickUp", c.gameObject);
        }
    }
}
