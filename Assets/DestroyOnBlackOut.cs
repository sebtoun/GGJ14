using UnityEngine;
using System.Collections;

public class DestroyOnBlackOut : MonoBehaviour 
{
    void blackOut()
    {
        Destroy(this.gameObject);
    }
}
