using UnityEngine;
using System.Collections;

public class DestroyParent : MonoBehaviour {
    void OnDestroy()
    {
        Destroy(this.transform.parent.gameObject);
    }
}
