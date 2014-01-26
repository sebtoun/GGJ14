using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections.Generic;

public class CanPickUp : MonoBehaviour 
{
#if UNITY_EDITOR
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
            BroadcastMessage("pickUp", new GameObject("gun"));
    }
#endif
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Item") 
        {
            BroadcastMessage("pickUp", c.gameObject);
        }
    }
}
