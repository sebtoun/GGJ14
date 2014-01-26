using UnityEngine;
using System.Collections;

public class OnTargetShot : MonoBehaviour {
    public GameObject decalPrefab;

    void targetWasHit(RaycastHit target)
    {
        if (target.collider.tag == "Alien")
        {
            target.collider.gameObject.SendMessageUpwards("die", target, SendMessageOptions.DontRequireReceiver);
        }
        else if (target.collider.tag == "Man")
        {
            target.collider.gameObject.SendMessageUpwards("die", target, SendMessageOptions.DontRequireReceiver);
        }
        else
        {
            GameObject.Instantiate(decalPrefab, target.point + target.normal * 0.1f, Quaternion.LookRotation(target.normal, Vector3.up));
        }
    }
}
