using UnityEngine;
using System.Collections;

public class FallOnZY : MonoBehaviour 
{
    Vector3 forward;
    Vector3 up;
    bool start;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.1f);
        forward = transform.forward;
        float right = Vector3.Dot(transform.right, Vector3.up);
        up = ((right >= 0) ? Vector3.right : Vector3.left);
        start = true;
    }
    void FixedUpdate()
    {
        if (start)
        {
            rigidbody.MoveRotation(Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(forward, up), 0.01f));
        }
    }
}
