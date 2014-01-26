using UnityEngine;
using System.Collections;

public class DestroyOnDie : MonoBehaviour 
{
    void die()
    {
        Destroy(this.gameObject);
    }
}
