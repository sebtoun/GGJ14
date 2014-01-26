using UnityEngine;
using System.Collections;

public class FixedHeight : MonoBehaviour 
{
    public float height = 3;
    public float time = 0.5f;

    void Start()
    {
        iTween.MoveTo(this.gameObject, this.transform.parent.position + Vector3.up * height, time);
    }

    //void Update () 
    //{
    //    Vector3 pos = this.transform.position;
    //    pos.y = height;
    //    this.transform.position = pos;
    //}
}
