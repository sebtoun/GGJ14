using UnityEngine;
using System.Collections;

public class SlideOnOpen : MonoBehaviour {
    public Vector3 direction;
    public float time;
    public bool moveParent = true;

    void open()
    {
        iTween.MoveAdd((moveParent ? this.transform.parent.gameObject : this.gameObject), Vector3.Dot(direction.normalized, this.GetComponentInChildren<Renderer>().bounds.size) * direction, time);
    }
}
